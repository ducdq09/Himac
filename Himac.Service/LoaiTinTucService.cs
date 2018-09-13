using Himac.Data.Infrastructure;
using Himac.Data.Repositories;
using Himac.Model.Models;
using System.Collections.Generic;

namespace Himac.Service
{
    public interface ILoaiTinTucService
    {
        IEnumerable<LoaiTinTuc> SelectAll();

        LoaiTinTuc SelectById(int id);

        LoaiTinTuc Insert(LoaiTinTuc LoaiTinTuc);

        void Update(LoaiTinTuc LoaiTinTuc);

        LoaiTinTuc Delete(int id);

        void Save();
    }

    public class LoaiTinTucService : ILoaiTinTucService
    {
        private ILoaiTinTucRepository _loaiTinTucRepository;

        private IUnitOfWork _unitOfWork;

        public LoaiTinTucService(ILoaiTinTucRepository loaiTinTucRepository, IUnitOfWork unitOfWork)
        {
            this._loaiTinTucRepository = loaiTinTucRepository;
            this._unitOfWork = unitOfWork;
        }

        public IEnumerable<LoaiTinTuc> SelectAll()
        {
            return _loaiTinTucRepository.GetAll();
        }

        public LoaiTinTuc SelectById(int id)
        {
            return _loaiTinTucRepository.GetSingleById(id);
        }

        public LoaiTinTuc Insert(LoaiTinTuc LoaiTinTuc)
        {
            return _loaiTinTucRepository.Add(LoaiTinTuc);
        }

        public void Update(LoaiTinTuc LoaiTinTuc)
        {
            _loaiTinTucRepository.Update(LoaiTinTuc);
        }

        public LoaiTinTuc Delete(int id)
        {
            return _loaiTinTucRepository.Delete(id);
        }

        public void Save()
        {
            _unitOfWork.Commit();
        }
    }
}