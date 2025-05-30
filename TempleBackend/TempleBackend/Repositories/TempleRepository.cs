﻿using TempleBackend.Models;

namespace TempleBackend.Repositories;

public class TempleRepository : ITempleRepository
{
    public Temple GetTemple()
    {
        return new Temple
        {
            Name = "Weija Temple",
            Address = "Kaohsiung City, Taiwan",
            Phone = "123-456-7890",
            Description = "A beautiful temple located in Weija.",
            Deities = new List<Deity>()
            {
                new ()
                {
                    Id = 0,
                    Name = "豬八戒",
                    Title = "天蓬元帥",
                    Description = "西遊神",
                }
            },


        };
    }
}