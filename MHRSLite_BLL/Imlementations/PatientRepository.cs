﻿using MHRSLite_BLL.Contracts;
using MHRSLite_DAL;
using MHRSLite_EL.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace MHRSLite_BLL.Imlementations
{
    public class PatientRepository :Repository<Patient>,IPatientRepository
    {
        private readonly MyContext _myContext;
        public PatientRepository(MyContext myContext)
            : base(myContext)
        {

        }
    }
}
