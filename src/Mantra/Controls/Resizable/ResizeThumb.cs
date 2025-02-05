﻿using System;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;

// ReSharper disable once CheckNamespace
namespace Mantra;

/// <summary>
/// 调整大小Thumb 只更新 DesignerContainer 的宽度、高度和/或位置，具体取决于 ResizeThumb 的垂直和水平对齐方式。
/// </summary>
internal class ResizeThumb : Thumb
{
    #region Construction

    /// <summary>
    /// 默认构造函数
    /// </summary>
    public ResizeThumb()
    {
        DragDelta += HandleDragDelta;
    }

    /// <summary>
    /// 处理拖动
    /// </summary>
    /// <param name="sender">object</param>
    /// <param name="e">DragDeltaEventArgs</param>
    private void HandleDragDelta(object? sender, DragDeltaEventArgs e)
    {
        // DataContext is DesignItem
        if (DataContext is ContentControl container)
        {
            double deltaVertical, deltaHorizontal;
            switch (VerticalAlignment)
            {
                case VerticalAlignment.Bottom:
                    deltaVertical = Math.Min(-e.VerticalChange, container.ActualHeight - container.MinHeight);
                    container.Height -= deltaVertical;
                    break;
                case VerticalAlignment.Top:
                    deltaVertical = Math.Min(e.VerticalChange, container.ActualHeight - container.MinHeight);
                    var top = container.GetCanvasTopWithCascade(out var element);
                    Canvas.SetTop(element, top + deltaVertical);
                    container.Height -= deltaVertical;
                    break;
            }

            switch (HorizontalAlignment)
            {
                case HorizontalAlignment.Left:
                    deltaHorizontal = Math.Min(e.HorizontalChange, container.ActualWidth - container.MinWidth);
                    var left = container.GetCanvasLeftWithCascade(out var element);
                    Canvas.SetLeft(element, left + deltaHorizontal);
                    container.Width -= deltaHorizontal;
                    break;
                case HorizontalAlignment.Right:
                    deltaHorizontal = Math.Min(-e.HorizontalChange, container.ActualWidth - container.MinWidth);
                    container.Width -= deltaHorizontal;
                    break;
            }
        }

        e.Handled = true;
    }

    #endregion
}