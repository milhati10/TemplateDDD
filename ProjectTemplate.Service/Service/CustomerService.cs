using AutoMapper;
using ProjectTemplate.Domain.Entities;
using ProjectTemplate.Domain.Repositories;
using ProjectTemplate.Interface.DTO;
using ProjectTemplate.Interface.Services;
using System;

namespace ProjectTemplate.Service.Service
{
    public class CustomerService : ICustomerService
    {
        protected readonly ICustomerRepository _customerRepository;
        protected readonly IMapper _mapper;

        public CustomerService(ICustomerRepository customerRepository,
                               IMapper mapper )
        {
            _customerRepository = customerRepository;
            _mapper = mapper;
        }

        public CustomerDTO Edit(CustomerDTO customerDTO)
        {
            var customer = _mapper.Map<Customer>(customerDTO);

            if (customer.Valid)
            {
                customer.AddNotifications(customer);
                return null;
            }

            _customerRepository.Edit(customer);

            return customerDTO;
        }

        public CustomerDTO GetCustomerByID(string ID)
        {
            var guid = Guid.Parse(ID);

            var customer = _customerRepository.GetByID(guid);

            return _mapper.Map<CustomerDTO>(customer);
        }

        public CustomerDTO Save(CustomerDTO customerDTO)
        {
            var customer = _mapper.Map<Customer>(customerDTO);

            if (customer.Valid)
            {
                customer.AddNotifications(customer);
                
                return null;
            }

            _customerRepository.Save(customer);

            return customerDTO;
        }
    }
}
