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
            //Dapper
            _unitOfWorkDapper.Begin();
            var x = await _unitOfWorkDapper.repositoryDapper.ExecuteAsync(@"
INSERT into BaoCao(Id, KieuBaoCao,CreatedAt,CreatedBy,UpdatedAt,UpdatedBy,TrangThai,IsDeleted) 
VALUEs (NEWID(),1,GETDATE(),NEWID(),GETDATE(),NEWID(),0,0)", transaction: _unitOfWorkDapper.Transaction);

            //EF
            var response = await _unitOfWorkEF.baoCaoRepositoryEF.GetAll();
            _unitOfWorkDapper.Commit();


            //Mongo
            //_unitOfWorkMongo.baoCaoRepositoryMongo.Add(new BaoCao() { TrangThai = 1 });
            //await _unitOfWorkMongo.CommitAsync();
            //var response = await _unitOfWorkMongo.repositoryMongo.GetAll();
            return response;

        }
    }
}
