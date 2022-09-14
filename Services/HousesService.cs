using System;
using System.Collections.Generic;
using gregslistFinnaly.Models;
using gregslistFinnaly.Repositories;

namespace gregslistFinnaly.Services
{
    private readonly HousesRepository _houseRepo;

    public HousesService(HousesRepository HouseRepo)
    {
        _houseRepo = HouseRepo;
    }

    internal List<House> GetAll()
    {
        return _houseRepo.GetAll();
    }

}