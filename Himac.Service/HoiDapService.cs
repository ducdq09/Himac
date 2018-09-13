using Himac.Data.Infrastructure;
using Himac.Data.Repositories;
using Himac.Model.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Himac.Service
{
    public interface IHoiDapService
    {
        IEnumerable<HoiDap> SelectAll();

        HoiDap SelectById(int id);

        HoiDap Insert(HoiDap HoiDap);

        void Update(HoiDap HoiDap);

        HoiDap Delete(int id);

        void Save();

        IEnumerable<HoiDap> Select5HoiDapMoiNhat();
    }

    public class HoiDapService : IHoiDapService
    {
        private IHoiDapRepository _HoiDapRepository;

        private IUnitOfWork _unitOfWork;

        public HoiDapService(IHoiDapRepository HoiDapRepository, IUnitOfWork unitOfWork)
        {
            this._HoiDapRepository = HoiDapRepository;
            this._unitOfWork = unitOfWork;
        }

        public IEnumerable<HoiDap> SelectAll()
        {
            return _HoiDapRepository.GetAll();
        }

        public HoiDap SelectById(int id)
        {
            return _HoiDapRepository.GetSingleById(id);
        }

        public HoiDap Insert(HoiDap HoiDap)
        {
            return _HoiDapRepository.Add(HoiDap);
        }

        public void Update(HoiDap HoiDap)
        {
            _HoiDapRepository.Update(HoiDap);
        }

        public HoiDap Delete(int id)
        {
            return _HoiDapRepository.Delete(id);
        }

        public void Save()
        {
            _unitOfWork.Commit();
        }

        // Add new
        public IEnumerable<HoiDap> Select5HoiDapMoiNhat()
        {
            return _HoiDapRepository.Get5HoiDapMoiNhat().ToList();
        }
    }
}