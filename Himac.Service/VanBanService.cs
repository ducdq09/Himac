using Himac.Data.Infrastructure;
using Himac.Data.Repositories;
using Himac.Model.Models;
using System;
using System.Collections.Generic;

namespace Himac.Service
{
    public interface IVanBanService
    {
        IEnumerable<VanBan> SelectAll();

        VanBan SelectById(int id);

        VanBan Insert(VanBan vanBan);

        void Update(VanBan vanBan);

        VanBan Delete(int id);

        void Save();
    }

    public class VanBanService : IVanBanService
    {
        private IVanBanRepository _vanBanRepository;

        private IUnitOfWork _unitOfWork;

        public VanBanService(IVanBanRepository vanBanRepository, IUnitOfWork unitOfWork)
        {
            this._vanBanRepository = vanBanRepository;
            this._unitOfWork = unitOfWork;
        }

        public IEnumerable<VanBan> SelectAll()
        {
            return _vanBanRepository.GetAll();
        }

        public VanBan SelectById(int id)
        {
            return _vanBanRepository.GetSingleById(id);
        }

        public VanBan Insert(VanBan vanBan)
        {
            return _vanBanRepository.Add(vanBan);
        }

        public void Update(VanBan vanBan)
        {
            _vanBanRepository.Update(vanBan);
        }

        public VanBan Delete(int id)
        {
            return _vanBanRepository.Delete(id);
        }

        public void Save()
        {
            _unitOfWork.Commit();
        }
    }
}