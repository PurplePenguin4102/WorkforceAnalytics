using Entities;
using System.Linq;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataModel.Repository
{
    public class WorkerRepository
    {
        private WorkforceContext _workforceContext;

        public WorkerRepository()
        {
            _workforceContext = new WorkforceContext();
        }

        public Worker GetWorkerById(int id)
        {
            return (Worker)_workforceContext.Find(typeof(Worker), id);
        }
    }
}
