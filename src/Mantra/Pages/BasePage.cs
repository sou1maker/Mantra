﻿using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;

// ReSharper disable once CheckNamespace
namespace Mantra;

/// <summary>
/// The base page for all pages to gain base functionality
/// </summary>
internal class BasePage : Page
{
    #region Public Properties

    /// <summary>
    /// The animation the play when the page is first loaded
    /// </summary>
    public PageAnimation PageLoadAnimation { get; set; } = PageAnimation.SlideAndFadeInFromRight;

    /// <summary>
    /// The animation the play when the page is unloaded
    /// </summary>
    public PageAnimation PageUnloadAnimation { get; set; } = PageAnimation.SlideAndFadeOutToLeft;

    /// <summary>
    /// The time any slide animation takes to complete
    /// </summary>
    public float SlideSeconds { get; set; } = 0.4f;

    /// <summary>
    /// A flag to indicate if this page should animate out on load.
    /// Useful for when we are moving the page to another frame
    /// </summary>
    public bool ShouldAnimateOut { get; set; }
    
    /// <summary>
    /// The value from other page
    /// </summary>
    public object? PushValue { get; set; }

    #endregion

    #region Constructor

    /// <summary>
    /// Default constructor
    /// </summary>
    protected BasePage()
    {
        // If we are animating in, hide to begin with
        if (PageLoadAnimation != PageAnimation.None)
            Visibility = Visibility.Collapsed;

        // Listen out for the page loading
        Loaded += BasePage_LoadedAsync;
    }

    #endregion

    #region Animation Load / Unload

    /// <summary>
    /// Once the page is loaded, perform any required animation
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    private async void BasePage_LoadedAsync(object sender, RoutedEventArgs e)
    {
        // If we are setup to animate out on load
        if (ShouldAnimateOut)
            // Animate out the page
            await AnimateOutAsync();
        // Otherwise...
        else
            // Animate the page in
            await AnimateInAsync();
    }

    /// <summary>
    /// Animates the page in
    /// </summary>
    /// <returns></returns>
    public async Task AnimateInAsync()
    {
        // Make sure we have something to do
        if (PageLoadAnimation == PageAnimation.None)
            return;

        switch (PageLoadAnimation)
        {
            case PageAnimation.SlideAndFadeInFromRight:

                // Start the animation
                await this.SlideAndFadeInFromRightAsync(SlideSeconds);

                break;
        }
    }

    /// <summary>
    /// Animates the page out
    /// </summary>
    /// <returns></returns>
    public async Task AnimateOutAsync()
    {
        // Make sure we have something to do
        if (PageUnloadAnimation == PageAnimation.None)
            return;

        switch (PageUnloadAnimation)
        {
            case PageAnimation.SlideAndFadeOutToLeft:

                // Start the animation
                await this.SlideAndFadeOutToLeftAsync(SlideSeconds);

                break;
        }
    }

    #endregion
}