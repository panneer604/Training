﻿using BusinessModels;
using BusinessModels.DWI;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataLayer.Contracts.DWI
{
    public interface IGraphicLabelMappingDataAccess
    {
        CollectionResult<GraphicLabelMapping> GetAllGraphicLabelMapping(string Connectionstring, string BaseUrl);
        CollectionResult<GraphicLabelMapping> GetAllGraphicLabelMappingDetails(int PageIndex, int PageSize, string search, string Connectionstring, string BaseUrl);
        Result<GraphicLabelMapping> GetByGraphicLabelMappingId(int Id, string Connectionstring, string BaseUrl);

        Result<int> AddorUpdateGraphicLabelMapping(GraphicLabelMapping values, string Connectionstring);

        Result<int> DeleteGraphicLabelMapping(GraphicLabelMapping values, string Connectionstring);
    }
}
