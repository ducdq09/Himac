using Himac.Data.Infrastructure;
using Himac.Data.Repositories;
using Himac.Model.Models;
using System.Collections.Generic;

namespace Himac.Service
{
    public interface ILoaiVanBanService
    {
        IEnumerable<LoaiVanBan> SelectAll();

        LoaiVanBan SelectById(int id);

        LoaiVanBan Insert(LoaiVanBan loaiVanBan);

        void Update(LoaiVanBan loaiVanBan);

        LoaiVanBan Delete(int id);

        void Save();
    }

    public class LoaiVanBanService : ILoaiVanBanService
    {
        private ILoaiVanBanRepository _loaiVanBanRepository;
        private IUnitOfWork _unitOfWork;

        public LoaiVanBanService(ILoaiVanBanRepository loaiVanBanRepository, IUnitOfWork unitOfWork)
        {
            this._loaiVanBanRepository = loaiVanBanRepository;
            this._unitOfWork = unitOfWork;
        }

        public IEnumerable<LoaiVanBan> SelectAll()
        {
            return _loaiVanBanRepository.GetAll();
        }

        public LoaiVanBan SelectById(int id)
        {
            return _loaiVanBanRepository.GetSingleById(id);
        }

        public LoaiVanBan Insert(LoaiVanBan loaiVanBan)
        {
            return _loaiVanBanRepository.Add(loaiVanBan);
        }

        public void Update(LoaiVanBan loaiVanBan)
        {
            _loaiVanBanRepository.Update(loaiVanBan);
        }

        public LoaiVanBan Delete(int id)
        {
            return _loaiVanBanRepository.Delete(id);
        }

        public void Save()
        {
            _unitOfWork.Commit();
        }
    }
}