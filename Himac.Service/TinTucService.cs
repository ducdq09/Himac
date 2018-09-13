using Himac.Data.Infrastructure;
using Himac.Data.Repositories;
using Himac.Model.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Himac.Service
{
    public interface ITinTucService
    {
        IEnumerable<TinTuc> SelectAll();

        TinTuc SelectById(int id);

        TinTuc Insert(TinTuc vanBan);

        void Update(TinTuc vanBan);

        TinTuc Delete(int id);

        void Save();

        IEnumerable<TinTuc> Select16TinPhapLuatMoiNhat();
    }

    public class TinTucService : ITinTucService
    {
        private ITinTucRepository _tinTucRepository;

        private IUnitOfWork _unitOfWork;

        public TinTucService(ITinTucRepository tinTucRepository, IUnitOfWork unitOfWork)
        {
            this._tinTucRepository = tinTucRepository;
            this._unitOfWork = unitOfWork;
        }

        public IEnumerable<TinTuc> SelectAll()
        {
            return _tinTucRepository.GetAll();
        }

        public TinTuc SelectById(int id)
        {
            return _tinTucRepository.GetSingleById(id);
        }

        public TinTuc Insert(TinTuc vanBan)
        {
            return _tinTucRepository.Add(vanBan);
        }

        public void Update(TinTuc vanBan)
        {
            _tinTucRepository.Update(vanBan);
        }

        public TinTuc Delete(int id)
        {
            return _tinTucRepository.Delete(id);
        }

        public void Save()
        {
            _unitOfWork.Commit();
        }

        // Add new
        public IEnumerable<TinTuc> Select16TinPhapLuatMoiNhat()
        {
            return _tinTucRepository.Get16TinPhapLuatMoiNhat().ToList();
        }
    }
}