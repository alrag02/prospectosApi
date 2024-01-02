using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace prospectosApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProspectosController : ControllerBase
    {
        private readonly DataConnection.DataConnection _connection;

        public ProspectosController(DataConnection.DataConnection connection)
        {
            _connection = connection;
        }

        // GET: api/<ProspectosController>
        [HttpGet]
        public ActionResult Get()
        {
            try
            {
                return Ok(_connection.prospectos.ToList());
            }
            catch (Exception ex)
            {
                return BadRequest("No se pudo obtener los prospectos" + ex.Message);
            }
        }

        // GET api/<ProspectosController>/5
        [HttpGet("{id}"), ActionName("GetProspecto")]
        public ActionResult Get(int id)
        {
            try
            {
                var prospecto = _connection.prospectos.FirstOrDefault(g => g.id == id);
                return Ok(prospecto);
            }
            catch (Exception ex)
            {
                return BadRequest("No se pudo obtener el prospecto " + id + ". " + ex.Message);
            }
        }

        // POST api/<ProspectosController>
        [HttpPost]
        public ActionResult Post([FromBody] Models.Prospectos prospecto)
        {
            try
            {
                _connection.prospectos.Add(prospecto);
                _connection.SaveChanges();
                return CreatedAtRoute("GetProspecto", new { id = prospecto.id }, prospecto);
            }
            catch (Exception ex)
            {
                return BadRequest("No se pudo editar el prospecto. " + ex.Message);
            }
        }

        // PUT api/<ProspectosController>/5
        [HttpPut("{id}")]
        public ActionResult Put(int id, [FromBody] Models.Prospectos prospecto)
        {
            try
            {
                if (prospecto.id == id)
                {
                    _connection.Entry(prospecto).State = EntityState.Modified;
                    _connection.SaveChanges();
                    return CreatedAtRoute("GetProspecto", new { id = prospecto.id }, prospecto);
                }
                else
                {
                    return BadRequest();
                }
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        // DELETE api/<ProspectosController>/5
        [HttpDelete("{id}")]
        public ActionResult Delete(int id)
        {
            try
            {
                var prospecto = _connection.prospectos.FirstOrDefault(g => g.id == id);
                if (prospecto != null)
                {
                    _connection.prospectos.Remove(prospecto);
                    _connection.SaveChanges();
                    return Ok(id);
                }
                else
                {
                    return BadRequest();
                }
            }
            catch (Exception ex)
            {
                return BadRequest("No se pudo borrar el prospecto " + id + ". " + ex.Message);
            }
        }
    }
}
