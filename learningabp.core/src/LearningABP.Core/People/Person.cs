using Abp.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace LearningABP.People
{
    public class Person : Entity
    {
        public virtual string Name { get; set; }
    }
}
