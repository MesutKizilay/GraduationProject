﻿using Core.DataAccess;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Abstract
{
    public interface ITransporterHelperDal: IEntityRepository<TransporterHelper>
    {
        List<TransporterHelperDetailDto> GetTransporterHelperDetails();
        List<TransporterHelperDetailDto> GetTransporterHelperDetailsByEmail(string email);
    }
}