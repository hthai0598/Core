using BCDT.Core.Entities;
using Bussiness.IService;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using UnitOfWork.Dapper;
using UnitOfWork.UnitOfWork;
using UnitOfWork.UnitOfWork.Interface;

namespace Bussiness.Service
{
    public class BaoCaoService : IBaoCaoService
    {
        private readonly IUnitOfWorkEF _unitOfWorkEF;
        private readonly IUnitOfWorkDapper _unitOfWorkDapper;
        private readonly IUnitOfWorkMongo _unitOfWorkMongo;
        public BaoCaoService(IUnitOfWorkEF unitOfWorkEF, IUnitOfWorkDapper unitOfWorkDapper, IUnitOfWorkMongo unitOfWorkMongo)
        {
            this._unitOfWorkEF = unitOfWorkEF;
            this._unitOfWorkDapper = unitOfWorkDapper;
            this._unitOfWorkMongo = unitOfWorkMongo;
        }

        public async Task<IEnumerable<BaoCao>> GetAll()
        {
            //EF
            //var response = await _unitOfWorkEF.baoCaoRepositoryEF.GetAll();

            //Mongo
            //_unitOfWorkMongo.baoCaoRepositoryMongo.Add(new BaoCao() { TrangThai = 1 });
            //var x = await _unitOfWorkMongo.CommitAsync();
            //var response = await _unitOfWorkMongo.baoCaoRepositoryMongo.GetAll();

            var x = await _unitOfWorkMongo.CommitAsync();
            var response = await _unitOfWorkMongo.baoCaoRepositoryMongo.GetAll();
            return response;

        }
    }
}
