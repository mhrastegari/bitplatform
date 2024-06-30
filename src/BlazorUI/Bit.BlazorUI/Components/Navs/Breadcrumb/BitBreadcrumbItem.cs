﻿namespace Bit.BlazorUI;

public class BitBreadcrumbItem
{
    /// <summary>
    /// A unique value to use as a key of the breadcrumb item.
    /// </summary>
    public string? Key { get; set; }

    /// <summary>
    /// Text to display in the breadcrumb item.
    /// </summary>
    public string? Text { get; set; }

    /// <summary>
    /// URL to navigate to when the breadcrumb item is clicked.
    /// If provided, the breadcrumb will be rendered as a link.
    /// </summary>
    public string? Href { get; set; }

    /// <summary>
    /// CSS class attribute for breadcrumb item.
    /// </summary>
    public string? Class { get; set; }

    /// <summary>
    /// Style attribute for breadcrumb item.
    /// </summary>
    public string? Style { get; set; }

    /// <summary>
    /// Display the breadcrumb item as the selected item.
    /// </summary>
    public bool IsSelected { get; set; }

    /// <summary>
    /// Whether an item is enabled or not.
    /// </summary>
    public bool IsEnabled { get; set; } = true;

    /// <summary>
    /// Click event handler of the breadcrumb item.
    /// </summary>
    public Action<BitBreadcrumbItem>? OnClick { get; set; }
}