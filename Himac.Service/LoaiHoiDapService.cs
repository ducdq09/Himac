using Himac.Data.Infrastructure;
using Himac.Data.Repositories;
using Himac.Model.Models;
using System.Collections.Generic;

namespace Himac.Service
{
    public interface ILoaiHoiDapService
    {
        IEnumerable<LoaiHoiDap> SelectAll();

        LoaiHoiDap SelectById(int id);

        LoaiHoiDap Insert(LoaiHoiDap loaiHoiDap);

        void Update(LoaiHoiDap loaiHoiDap);

        LoaiHoiDap Delete(int id);

        void Save();
    }

    public class LoaiHoiDapService : ILoaiHoiDapService
    {
        private ILoaiHoiDapRepository _loaiHoiDapRepository;
        private IUnitOfWork _unitOfWork;

        public LoaiHoiDapService(ILoaiHoiDapRepository loaiHoiDapRepository, IUnitOfWork unitOfWork)
        {
            this._loaiHoiDapRepository = loaiHoiDapRepository;
            this._unitOfWork = unitOfWork;
        }

        public IEnumerable<LoaiHoiDap> SelectAll()
        {
            return _loaiHoiDapRepository.GetAll();
        }

        public LoaiHoiDap SelectById(int id)
        {
            return _loaiHoiDapRepository.GetSingleById(id);
        }

        public LoaiHoiDap Insert(LoaiHoiDap loaiHoiDap)
        {
            return _loaiHoiDapRepository.Add(loaiHoiDap);
        }

        public void Update(LoaiHoiDap loaiHoiDap)
        {
            _loaiHoiDapRepository.Update(loaiHoiDap);
        }

        public LoaiHoiDap Delete(int id)
        {
            return _loaiHoiDapRepository.Delete(id);
        }

        public void Save()
        {
            _unitOfWork.Commit();
        }
    }
}