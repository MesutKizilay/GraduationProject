﻿using Business.Abstract;
using Business.Cosntants;
using Core.Utilities.Results;
using DataAccess.Abstract;
using DataAccess.Concrete;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class FoodHelperManager : IFoodHelperService
    {
        IFoodHelperDal _foodHelperDal;
        public FoodHelperManager(IFoodHelperDal foodHelperDal)
        {
            _foodHelperDal = foodHelperDal;
        }
        public IResult Add(FoodHelper foodHelper)
        {
            _foodHelperDal.Add(foodHelper);
            return new SuccessResult();
        }

        public IResult Delete(FoodHelper foodHelper)
        {
            _foodHelperDal.Delete(foodHelper);
            return new SuccessResult();
        }

        public IDataResult<List<FoodHelper>> GetAll()
        {
            return new SuccessDataResult<List<FoodHelper>>(_foodHelperDal.GetAll());
        }

        public IDataResult<FoodHelper> GetById(int foodHelperId)
        {
            return new SuccessDataResult<FoodHelper>(_foodHelperDal.Get(f => f.Id == foodHelperId));
        }

        public IResult Update(FoodHelper foodHelper)
        {
            _foodHelperDal.Update(foodHelper);
            return new SuccessResult();
        }
    }
}