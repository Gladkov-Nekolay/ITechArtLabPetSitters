using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ItechArtLabPetsitters.Core.Entities;
using ItechArtLabPetsitters.Core.ServiceCore.Petsitters;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

[Route("api/[controller]")]
[ApiController]
public class PetsittersController : ControllerBase
{
    private readonly IPetsittersService service;
    public PetsittersController(IPetsittersService service)
    {
        this.service = service;
    }
    [HttpPost("Petsitter/{petsitterName}")]
    public async Task AsyncPostPetsitter(string petsitterName, string phone)
    {
        await service.AsyncAddPetsitter(petsitterName, phone);
    }
    [HttpDelete]
    public async Task AsyncDeletePetsitter(long ID)
    {
        await service.AsynkDeletePetsitter(ID);
    }
    [HttpGet]
    [Route("Petsitters")]
    public Task<List<Petsitter>> GetAll()
    {
        return service.AsyncGetAllPetsitters();
    }
}

