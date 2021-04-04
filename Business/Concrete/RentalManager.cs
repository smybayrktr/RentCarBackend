using Business.Abstract;
using Business.Constants;
using Core.Aspects.Autofac.Caching;
using Core.Aspects.Autofac.Performance;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Concrete
{
    public class RentalManager : IRentalService
    {
        IRentalDal _rentalDal;

        public RentalManager(IRentalDal rentalDal)
        {
            _rentalDal = rentalDal;
        }
        [PerformanceAspect(15)]
        public IResult Deliver(Rental rental)
        {
            if (rental.ReturnDate==null)
            {
                return new ErrorResult(Messages.CarInformation);
            }
            _rentalDal.Delete(rental);
            return new SuccessResult(Messages.Deliver);
        }
        [CacheAspect]
        public IDataResult<List<Rental>> GetAll()
        {
            return new SuccessDataResult<List<Rental>>(_rentalDal.GetAll(), Messages.Listed);
        }

        public IResult TakeDelivery(Rental rental)
        {
            rental.RentDate = DateTime.Now;
            return new SuccessResult(Messages.TakeDelivery);
        }
        [CacheRemoveAspect("IBrandService.Get")]
        public IResult Update(Rental rental)
        {
            _rentalDal.Update(rental);
            return new SuccessResult(Messages.Updated);
        }
    }
}
