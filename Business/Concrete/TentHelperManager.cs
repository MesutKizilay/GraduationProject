﻿using Business.Abstract;
using Core.Utilities.Results;
using DataAccess.Abstract;
using DataAccess.Concrete;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class TentHelperManager : ITentHelperService
    {
        ITentHelperDal _tentHelperDal;

        public TentHelperManager(ITentHelperDal tentHelperDal)
        {
            _tentHelperDal = tentHelperDal;
        }

        public IResult Add(TentHelper tentHelper)
        {
            _tentHelperDal.Add(tentHelper);
            return new SuccessResult();
        }

        public IResult Delete(TentHelper tentHelper)
        {
            _tentHelperDal.Delete(tentHelper);
            return new SuccessResult();
        }

        public IDataResult<List<TentHelper>> GetAll()
        {
            return new SuccessDataResult<List<TentHelper>>(_tentHelperDal.GetAll());
        }

        public IDataResult<TentHelper> GetById(int tentHelperId)
        {
            return new SuccessDataResult<TentHelper>(_tentHelperDal.Get(t => t.Id == tentHelperId));
        }

        public IDataResult<List<TentHelperDetailDto>> GetTentHelperDetails()
        {
            return new SuccessDataResult<List<TentHelperDetailDto>>(_tentHelperDal.GetTentHelperDetails());
        }

        public IDataResult<List<TentHelperDetailDto>> GetTentHelperDetailsByEmail(string email)
        {
            return new SuccessDataResult<List<TentHelperDetailDto>>(_tentHelperDal.GetTentHelperDetailsByEmail(email));
        }

        public IResult Update(TentHelper tentHelper)
        {
            _tentHelperDal.Update(tentHelper);
            return new SuccessResult();
        }
    }
}
