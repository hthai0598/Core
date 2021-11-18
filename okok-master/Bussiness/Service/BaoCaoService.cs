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
        private readonly IUnitOfWorkEF<BaoCao> _unitOfWorkEF;
        private readonly IUnitOfWorkDapper<BaoCao> _unitOfWorkDapper;
        private readonly IUnitOfWorkMongo<BaoCao> _unitOfWorkMongo;
        public BaoCaoService(IUnitOfWorkEF<BaoCao> unitOfWorkEF, IUnitOfWorkDapper<BaoCao> unitOfWorkDapper, IUnitOfWorkMongo<BaoCao> unitOfWorkMongo)
        {
            this._unitOfWorkEF = unitOfWorkEF;
            this._unitOfWorkDapper = unitOfWorkDapper;
            this._unitOfWorkMongo = unitOfWorkMongo;
        }

        public async Task<IEnumerable<BaoCao>> GetAll()
        {
            //EF
            var response = await _unitOfWorkEF.baoCaoRepositoryEF.GetAll();

            //Mongo
            //_unitOfWorkMongo.baoCaoRepositoryMongo.Add(new BaoCao() { TrangThai = 1 });
            //await _unitOfWorkMongo.CommitAsync();
            //var response = await _unitOfWorkMongo.repositoryMongo.GetAll();
            return response;

        }
    }
}
