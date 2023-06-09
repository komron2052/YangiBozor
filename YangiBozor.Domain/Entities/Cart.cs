﻿using YangiBozor.Domain.Comons;

namespace YangiBozor.Domain.Entities;

public class Cart : Auditable
{
    public long UserId { get; set; }
    public User User { get; set; }
    public ICollection<Product> Products { get; set; }
}
