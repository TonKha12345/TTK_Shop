using TTK_Shop.Data.Infrastructure;
using TTK_Shop.Data.Repositories;
using TTK_Shop.Model.Models;

namespace TTK_Shop.Service
{
    public interface IErrorService
    {
        Error Add(Error error);

        void SaveChange();
    }

    public class ErrorService : IErrorService
    {
        private IErrorRepository _errorRepository;
        private IUnitOfWork _unitOfWork;

        public ErrorService(IErrorRepository errorRepository, IUnitOfWork unitOfWork)
        {
            this._errorRepository = errorRepository;
            this._unitOfWork = unitOfWork;
        }

        public Error Add(Error error)
        {
            return _errorRepository.Add(error);
        }

        public void SaveChange()
        {
            _unitOfWork.Commit();
        }
    }
}