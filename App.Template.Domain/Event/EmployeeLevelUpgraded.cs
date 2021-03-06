﻿using App.Cqrs.Core.Event;

namespace App.Template.Domain.Event
{
    public class EmployeeLevelUpgraded : IEvent
    {
        public EmployeeLevelUpgraded(int level, decimal salary)
        {
            Level = level++;
            Salary = salary * 1.1m;
        }

        public int Version { get; set; }
        public int Level { get; protected set; }
        public decimal Salary { get; protected set; }
    }
}