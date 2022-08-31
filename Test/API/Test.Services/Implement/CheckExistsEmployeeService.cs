﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Test.Data.Repository;
using Test.Data.UnitOfWork;
using Test.Modal.Entities;
using Test.Services.Interface;

namespace Test.Services.Implement
{
    public class CheckExistsEmployeeService : BaseService, ICheckExistsEmployeeService
    {
        private readonly IRepository<Employee> _empRepo;

        public CheckExistsEmployeeService(IUnitOfWork unitOfWork, IRepository<Employee> empRepo) : base(unitOfWork)
        {
            _empRepo = empRepo;
        }
        public bool CheckExistsEmailEmployee(string email)
        {
            try
            {
                var checkExistEmail = _empRepo.Get(x => x.Email == email);

                return (checkExistEmail != null && checkExistEmail.Count() > 0);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public bool CheckExistsPhoneNumberEmployee(string phoneNumber)
        {
            try
            {
                var checkExistPhoneNumber = _empRepo.Get(x => x.PhoneNumber == phoneNumber);

                return (checkExistPhoneNumber != null && checkExistPhoneNumber.Count() > 0);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public bool CheckExistsUsernameEmployee(string username)
        {
            try
            {
                var checkExistUsername = _empRepo.Get(x => x.Username == username);

                //if (checkExist != null && checkExist.Count() > 0)
                //{
                //    return true;
                //}

                //return false;
                return (checkExistUsername != null && checkExistUsername.Count() > 0);
                //return _empRepo.GetAll().Any(x => x.Username == employee.Username);

            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }
}