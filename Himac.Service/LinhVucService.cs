using Himac.Data.Infrastructure;
using Himac.Data.Repositories;
using Himac.Model.Models;
using System;
using System.Collections.Generic;

namespace Himac.Service
{
    public interface ILinhVucService
    {
        IEnumerable<LinhVuc> SelectAll();

        LinhVuc SelectById(int id);

        LinhVuc Insert(LinhVuc loaiVanBan);

        void Update(LinhVuc loaiVanBan);

        LinhVuc Delete(int id);

        void Save();
    }

    public class LinhVucService : ILinhVucService
    {
        private readonly ILinhVucRepository _linhVucRepository;
        private readonly IUnitOfWork _unitOfWork;

        public LinhVucService(ILinhVucRepository linhVucRepository, IUnitOfWork unitOfWork)
        {
            this._linhVucRepository = linhVucRepository;
            this._unitOfWork = unitOfWork;
        }

        public IEnumerable<LinhVuc> SelectAll()
        {
            return _linhVucRepository.GetAll();
        }

        public LinhVuc SelectById(int id)
        {
            return _linhVucRepository.GetSingleById(id);
        }

        public LinhVuc Insert(LinhVuc loaiVanBan)
        {
            return _linhVucRepository.Add(loaiVanBan);
        }

        public void Update(LinhVuc loaiVanBan)
        {
            _linhVucRepository.Update(loaiVanBan);
        }

        public LinhVuc Delete(int id)
        {
            return _linhVucRepository.Delete(id);
        }

        public void Save()
        {
            _unitOfWork.Commit();
        }
    }
}