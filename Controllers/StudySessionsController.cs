using Microsoft.AspNetCore.Mvc;
using StudySessionAPI.Models;
using StudySessionAPI.Data;
using Microsoft.AspNetCore.JsonPatch;

namespace StudySessionAPI.Controllers
{
    [ApiController]
    [Route("api/[Controller]")]
    public class StudySessionsController:ControllerBase
    {

        [HttpGet]
        public ActionResult<List<StudySession>> GetSessions()
        {
            return Ok(StudySessionStore.Sessions);
        }

        [HttpGet("{id}")]
        public ActionResult<StudySession> GetSession(int id)
        {
            try
            {
                var session = StudySessionStore.Sessions.AsParallel().FirstOrDefault(s => s.Id == id);
                if(session == null)
                {
                    return NotFound(new {message = "Session not found!"});
                }
                return Ok(session);
            }
            catch (Exception e)
            {
                return StatusCode(500, new{message = "Server Error -_-",error = e.Message});
            }
        }

        [HttpPost]
        public ActionResult<StudySession> CreateSession(StudySession session)
        {
            session.Id = StudySessionStore.Sessions.Count+1;
            StudySessionStore.Sessions.Add(session);
            return CreatedAtAction(nameof(GetSession),new {id = session.Id},session);
        }
        
        [HttpPut("{id}")]
        public ActionResult<StudySession> UpdateSession(StudySession UpdatedSession, int id)
        {
            
            var session = StudySessionStore.Sessions.AsParallel().FirstOrDefault(s => s.Id == id);
            if(session == null)
            {
                return NotFound(new {message = "Session not found!"});
            }
            session.Subject = UpdatedSession.Subject;
            session.StartTime = UpdatedSession.StartTime;
            session.EndTime = UpdatedSession.EndTime;
            session.FocusLevel = UpdatedSession.FocusLevel;
            session.Notes = UpdatedSession.Notes;
            return NoContent();
        }

        [HttpPatch("{id}")]
        public IActionResult EditSession(int id, [FromBody] JsonPatchDocument<StudySession> patch)
        {
            var session = StudySessionStore.Sessions.FirstOrDefault(s => s.Id == id);
            if (session == null)
            {
                return NotFound(new {message = "Session not found!"});
            }
            patch.ApplyTo(session, ModelState);
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            return Ok(session);
        }

        [HttpDelete("{id}")]
        public ActionResult<StudySession> DeleteSession(int id)
        {
            var session = StudySessionStore.Sessions.AsParallel().FirstOrDefault(s => s.Id == id);
            if (session == null)
            {
                return NotFound(new{message = "Session not found!"});
            }
            StudySessionStore.Sessions.Remove(session);
            return NoContent();
        }



    }
}