using Entities;
using System.Linq;
using System;
using System.Collections.Generic;
using System.Text;
using DataModel;

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
            return _workforceContext.Workers.Find(id);
        }

        public Address GetAddressById(int id)
        {
            return _workforceContext.Addresses.Find(id);
        }

        public Contact GetContactById(int id)
        {
            return _workforceContext.Contacts.Find(id);
        }
    }
}
