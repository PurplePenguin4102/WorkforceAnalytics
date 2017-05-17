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

        public List<Worker> GetAllWorkersAtAddress(Address addr)
        {
            return _workforceContext.Workers.Where(wo => wo.HomeAddress == addr).ToList();
        }

        public Dictionary<Address, List<Worker>> GetAllWorkersGroupedByAddress()
        {
            return _workforceContext.Workers
                .GroupBy(wo => wo.HomeAddress)
                .Select(grp => new
                {
                    key = grp.Key,
                    val = grp.ToList()
                })
                .ToDictionary(a => a.key, a => a.val); 
        }

        public List<Contact> GetContactDetailsOfWorkersInPostCode(string PostCode)
        {
            return (from worker in _workforceContext.Workers
                    where worker.HomeAddress.PostCode == PostCode
                    select worker.ContactDetails).ToList();
        }

    }
}
