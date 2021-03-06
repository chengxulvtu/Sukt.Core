﻿using Microsoft.Extensions.DependencyInjection;
using Sukt.Core.Domain.DomainRepository.DictionaryRepository;
using Sukt.Core.Domain.Models.DataDictionary;
using Sukt.Core.DomainRealization.Base;
using Sukt.Core.Shared.Attributes.Dependency;
using System;
using System.Collections.Generic;
using System.Text;

namespace Sukt.Core.DomainRealization.Repository.DictionaryRepository
{
    [Dependency(ServiceLifetime.Scoped)]
    public class DataDictionaryRepository : BaseRepository<DataDictionaryEntity, Guid>, IDataDictionaryRepository
    {
        public DataDictionaryRepository(IServiceProvider serviceProvider) : base(serviceProvider)
        {
        }
    }
}
