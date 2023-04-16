using FeeCalculator.Core.Models;
using FeeCalculator.Core.Services;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Linq;
using Core.Enums;

namespace FeeCalculator.Services
{
    public class FeeService : IFeeService
    {
        #region Variables

        private readonly ILoggerService _loggerService;
        private readonly string _nameSpace = System.Reflection.MethodBase.GetCurrentMethod().DeclaringType.Namespace;

        #endregion

        #region Constructor

        public FeeService(ILoggerService loggerService)
        {
            _loggerService = loggerService;
        }

        #endregion

        #region Public methods

        //public async Task<int> AddUpdate(Document document)
        //{
        //    try
        //    {
        //        Data.Documents entity = new Data.Documents().CopyFrom(document);
        //        if (entity.Id == 0)
        //            await _uow.RepositoryA<Data.Documents>().Add(entity);
        //        else
        //            _uow.RepositoryA<Data.Documents>().Update(entity);

        //        await _uow.SaveChanges();
        //        return entity.Id;
        //    }
        //    catch (Exception ex)
        //    {
        //        _loggerService.AddFileLog(_nameSpace + " " + System.Reflection.MethodBase.GetCurrentMethod().Name, ex.Message + " ; documentId = " + document.Id.ToString());
        //    }
        //    return (int)DbError.ErrorCreate;
        //}

        //public async Task<Document> GetDocument(int id)
        //{
        //    try
        //    {
        //        var model = await _uow.RepositoryA<Data.Documents>().Get(id);
        //        if (model != null)
        //        {
        //            return new Document().CopyFrom(model);
        //        }
        //    }
        //    catch(Exception ex)
        //    {
        //        _loggerService.AddFileLog(_nameSpace + " " + System.Reflection.MethodBase.GetCurrentMethod().Name, ex.Message + " ; documentId = " + id.ToString());
        //    }
        //    return null;
        //}

        //public async Task<List<Document>> GetDocuments()
        //{
        //    try
        //    {
        //        var model = await _uow.RepositoryA<Data.Documents>().GetAll();
        //        if (model.Count != 0)
        //        {
        //            return model.Select(x => new Document().CopyFrom(x)).ToList();
        //        }

        //    }
        //    catch (Exception ex)
        //    {
        //        _loggerService.AddFileLog(_nameSpace + " " + System.Reflection.MethodBase.GetCurrentMethod().Name, ex.Message );
        //    }
        //    return null;
        //}

        //public async Task<List<VDocument>> GetViewDocuments()
        //{
        //    try
        //    {
        //        var model = await _uow.RepositoryA<Data.V_Document>().GetAll();
        //        if (model.Count != 0)
        //        {
        //            return model.Select(x => new VDocument().CopyFrom(x)).ToList();
        //        }

        //    }
        //    catch (Exception ex)
        //    {
        //        _loggerService.AddFileLog(_nameSpace + " " + System.Reflection.MethodBase.GetCurrentMethod().Name, ex.Message);
        //    }
        //    return null;

        //}
        public Fee Get(int id)
        {
            throw new NotImplementedException();
        }

        public Fee GetAll()
        {
            throw new NotImplementedException();
        }

        public Category GetCategory()
        {
            throw new NotImplementedException();
        }

        #endregion

        #region Private methods



        #endregion

    }
}
