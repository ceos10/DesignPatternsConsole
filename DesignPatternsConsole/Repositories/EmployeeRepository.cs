﻿using Bogus;
using DesignPatternsConsole.Models;
using System.Collections.Generic;

namespace DesignPatternsConsole.Repositories
{
    public class EmployeeRepository : IEmployeeRepository
    {
        readonly AppSettings _appSettings;
        public EmployeeRepository(AppSettings appSettings)
        {
            _appSettings = appSettings;
        }

        public List<Employee> GetEmployees()
        {
            int nextId = 1;
            var faker = new Faker<Employee>()
                .RuleFor(c => c.Id, f => nextId++)
                .RuleFor(c => c.Name, f => f.Person.FirstName)
                .RuleFor(c => c.Experience, f => f.Random.Int(1, 10));

            return faker.Generate(_appSettings.TestingAmount);
        }
    }
}
