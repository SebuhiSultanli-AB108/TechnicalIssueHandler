﻿namespace TechnicalIssueHandler.Core.Entities;

public abstract class BaseEntity
{
    public Guid Id { get; set; }
    public bool IsDeleted { get; set; }
}