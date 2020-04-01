﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Sukt.Core.Shared.Entity
{
    public interface IFullAuditedEntity<TPrimaryKey>:ICreatedAudited<TPrimaryKey>, IModifyAudited<TPrimaryKey>, ISoftDelete where TPrimaryKey:struct
    {

    }
}
