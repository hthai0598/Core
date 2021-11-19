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
            //Dapper
            //_unitOfWorkDapper.Begin();
            //var x = await _unitOfWorkDapper.GetRepository<BaoCao>().ExecuteAsync(@"
            //INSERT into BaoCao(Id, KieuBaoCao,CreatedAt,CreatedBy,UpdatedAt,UpdatedBy,TrangThai,IsDeleted) 
            //VALUEs (NEWID(),1,GETDATE(),NEWID(),GETDATE(),NEWID(),0,0)", transaction: _unitOfWorkDapper.Transaction);
            //_unitOfWorkDapper.Commit();

            //EF
            var response = await _unitOfWorkEF.GetRepository<BaoCao>().GetAll();
            //var response2 = await _unitOfWorkEF.GetRepository<BaoCao>().GetAll();
            //var response3 = await _unitOfWorkEF.GetRepository<BieuMau>().GetAll();
            //var response = await _unitOfWorkEF.baoCaoRepositoryEF.GetAll();


            //Mongo
            //_unitOfWorkMongo.baoCaoRepositoryMongo.Add(new BaoCao() { TrangThai = 1 });
            //await _unitOfWorkMongo.CommitAsync();
            //var response = await _unitOfWorkMongo.GetRepository<BaoCao>().GetAll();
            //var response2 = await _unitOfWorkMongo.GetRepository<BaoCao>().GetAll();
            //var response2 = await _unitOfWorkMongo.GetRepository<BieuMau>().GetAll();
            return response;

        }
    }
}
