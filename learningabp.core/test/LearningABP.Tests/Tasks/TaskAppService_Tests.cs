using LearningABP.Tasks;
using System;
using System.Collections.Generic;
using System.Text;
using Shouldly;
using Xunit;
using System.Linq;
using Abp.Runtime.Validation;

namespace LearningABP.Tests.Tasks
{
    public class TaskAppService_Tests : LearningABPTestBase
    {
        private readonly ITaskAppService _taskAppService;

        public TaskAppService_Tests()
        {
            _taskAppService = Resolve<ITaskAppService>();
        }
    }
}
