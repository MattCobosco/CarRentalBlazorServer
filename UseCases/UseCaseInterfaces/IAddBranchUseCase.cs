﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CoreBusiness;

namespace UseCases.UseCaseInterfaces
{
    public interface IAddBranchUseCase
    {
        void Execute(Branch branch);
    }
}
