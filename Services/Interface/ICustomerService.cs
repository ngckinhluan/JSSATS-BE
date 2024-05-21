﻿using BusinessObjects.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services.Interface
{
    public interface ICustomerService
    {
        public Task<IEnumerable<Customer?>?> GetCustomers();
        public Task<Customer?> GetCustomerById(int id);
        public Task<int> CreateCustomer(Customer customer);
        public Task<int> UpdateCustomer(Customer customer);
        public Task<int> DeleteCustomer(int id);
    }
}