using CRM_Dev.Application.Abstractions;
using CRM_Dev.Application.Commands.Contact.Register;
using CRM_Dev.Application.Commands.Contact.Update;
using CRM_Dev.Application.Commands.Opportunity.DeleteOpportunity;
using CRM_Dev.Application.Queries.Contact.ListContacts;
using CRM_Dev.Core.Entities;
using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory.Database;

namespace CRM_Dev.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ContactController : ControllerBase
    {

        #region Mediator

        private readonly IMediator _mediator;
        public ContactController(IMediator mediator) => _mediator = mediator;

        #endregion

        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            var query = new ListContactsQuery();

            var result = await _mediator.Send(query);
            if (result.Any())
                return NotFound(Result<object>.NotFound());

            return Ok(result);
        }

        [HttpPost("GetByFilter")]
        public async Task<IActionResult> GetByFilter(ListContactsQuery query)
        {
            var result = await _mediator.Send(query);
            if (result.Any())
                return NotFound(Result<object>.NotFound());

            return Ok(result);
        }

        [HttpPost]
        public async Task<IActionResult> Register(RegisterContactCommand command)
        {
            var result = await _mediator.Send(command);
            if (!result)
                return BadRequest(Result<object>.Failure());

            return Created("Your Contact was registered successfully!", command);
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> Update(UpdateContactCommand command)
        {
            var result = await _mediator.Send(command);
            if (!result)
                return NotFound(Result<object>.Failure());

            return NoContent();
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            var command = new DeleteOpportunityCommand(id);

            var result = await _mediator.Send(command);
            if (!result)
                return NotFound(Result<object>.Failure());

            return NoContent();
        }
    }
}
