﻿using AgendaApi.Data.Repository.Interfaces;
using AgendaApi.Entities;
using AgendaApi.Models;
using AutoMapper;

namespace AgendaApi.Data.Repository.Implementations
{
    public class ContactRepository : IContactRepository
    {
        private readonly AgendaContext _context;
        private readonly IMapper _mapper;

        public ContactRepository(AgendaContext context, IMapper autoMapper)
        {
            _context = context;
            _mapper = autoMapper;
        }
        public List<Contact> GetAll()
        {
            return _context.Contacts.ToList();
        }

        public void Create(CreateContactDto dto)
        {
            _context.Contacts.Add(_mapper.Map<Contact>(dto));
        }
    }
}
