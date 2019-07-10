﻿using System;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using MijnSauna.Backend.Api.Common;
using MijnSauna.Backend.Logic.Interfaces;
using MijnSauna.Common.DataTransferObjects.Samples;

namespace MijnSauna.Backend.Api.Controllers
{
    [Route("api")]
    [ApiController]
    public class SamplesController : ApiController<ISampleLogic>
    {
        public SamplesController(ISampleLogic sampleLogic) : base(sampleLogic) { }

        [HttpGet("sessions/{sessionId}/samples")]
        public Task<IActionResult> GetSamplesForSession(Guid sessionId)
        {
            return Execute(x => x.GetSamplesForSession(sessionId));
        }

        [HttpPost("sessions/{sessionId}/samples")]
        public Task<IActionResult> CreateSampleForSession(Guid sessionId, [FromBody] CreateSampleForSessionRequest request)
        {
            return Execute(x => x.CreateSampleForSession(sessionId, request));
        }
    }
}