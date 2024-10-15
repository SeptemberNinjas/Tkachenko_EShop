﻿using eshop.Core.SaleItems;

namespace eshop.Core;

/// <summary>
/// Линия списка торговой единицы
/// </summary>
public class ItemsListLine
{
    private readonly SaleItem _lineItem;
    private int _count;

    /// <summary>
    /// Идентификатор элемента
    /// </summary>
    public int ItemId => _lineItem.Id;

    /// <summary>
    /// Тип элемента
    /// </summary>
    public ItemTypes ItemType => _lineItem.ItemType;

    /// <summary>
    /// Текст, отображаемый в списке элементов
    /// </summary>
    public string Text => $"{ItemType}: {_lineItem?.Name} | Цена: {_lineItem?.Price:F2} | Кол-во: {Count}";

    /// <summary>
    /// Количество элементов в линии
    /// </summary>
    public int Count { get; set; }

    /// <summary>
    /// Суммарная стоимость по линии
    /// </summary>
    public decimal LineSum => (_lineItem?.Price ?? 0) * Count;

    /// <inheritdoc cref="ItemsListLine"/>
    public ItemsListLine(SaleItem lineItem, int requestedCount)
    {
        _lineItem = lineItem;
        Count = requestedCount;
    }

    public ItemsListLine(SaleItem lineItem) : this(lineItem, 1) { }
}