using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using prospectosApi.DataConnection;
using prospectosApi.Models;

namespace prospectosApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DocumentosController : ControllerBase
    {
        private readonly DataConnection.DataConnection _connection;

        public DocumentosController(DataConnection.DataConnection context)
        {
            _connection = context;
        }

        // GET: api/<DocumentosController>
        [HttpGet]
        public ActionResult Get()
        {
            try
            {
                return Ok(_connection.Documentos.ToList());
            }
            catch (Exception ex)
            {
                return BadRequest("No se pudo obtener los documentos" + ex.Message);
            }
        }

        // GET api/<DocumentosController>/5
        [HttpGet("{id}"), ActionName("GetDocumento")]
        public ActionResult Get(int id)
        {
            try
            {
                var documento = _connection.Documentos.FirstOrDefault(g => g.id == id);
                return Ok(documento);
            }
            catch (Exception ex)
            {
                return BadRequest("No se pudo obtener el documento " + id + ". " + ex.Message);
            }
        }

        // POST api/<DocumentosController>
        [HttpPost]
        public ActionResult Post([FromBody] Models.Documentos documento)
        {
            try
            {
                _connection.Documentos.Add(documento);
                _connection.SaveChanges();
                return CreatedAtRoute("GetDocumento", new { id = documento.id }, documento);
            }
            catch (Exception ex)
            {
                return BadRequest("No se pudo editar el documento. " + ex.Message);
            }
        }
    }
}
