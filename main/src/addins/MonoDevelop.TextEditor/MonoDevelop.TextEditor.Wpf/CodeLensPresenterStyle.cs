//
// Copyright (c) Microsoft Corp. (https://www.microsoft.com)
//
// Permission is hereby granted, free of charge, to any person obtaining a copy
// of this software and associated documentation files (the "Software"), to deal
// in the Software without restriction, including without limitation the rights
// to use, copy, modify, merge, publish, distribute, sublicense, and/or sell
// copies of the Software, and to permit persons to whom the Software is
// furnished to do so, subject to the following conditions:
//
// The above copyright notice and this permission notice shall be included in
// all copies or substantial portions of the Software.
//
// THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
// IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
// FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE
// AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER
// LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM,
// OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN
// THE SOFTWARE.

using System.ComponentModel.Composition;
using System.Windows.Media;
using Microsoft.VisualStudio.Language.Intellisense;
using Microsoft.VisualStudio.Text.Formatting;
using Microsoft.VisualStudio.Utilities;

namespace MonoDevelop.TextEditor.Wpf
{
    //[Export(typeof(CodeLensPresenterStyle))]
    //[Name("MonoDevelopCodeLensPresenterStyle")]
    //[Order(Before = "default")]
    // class MonoDevelopCodeLensPresenterStyle : CodeLensPresenterStyle
    // {
    //     public MonoDevelopCodeLensPresenterStyle()
    //     {
    //         var blackBrush = new SolidColorBrush(Colors.Black);
    //         var whiteBrush = new SolidColorBrush(Colors.White);

    //         var typeface = new Typeface("Calibri");
    //         var size = 8.0 * 96.0 / 72.0;

    //         var textRunProperties = TextFormattingRunProperties.CreateTextFormattingRunProperties(
    //             foreground: blackBrush,
    //             background: null,
    //             typeface: typeface,
    //             size: size,
    //             textDecorations: null,
    //             textEffects: null,
    //             hintingSize: null,
    //             cultureInfo: null);

    //         this.IndicatorTextRunProperties = textRunProperties;
    //         this.IndicatorHoveredTextRunProperties = textRunProperties;
    //         this.IndicatorDisabledTextRunProperties = textRunProperties;
    //         this.IndicatorSeparatorBrush = blackBrush;
    //         this.PopupBackgroundBrush = whiteBrush;
    //         this.PopupTextBrush = blackBrush;
    //         this.PopupBorderBrush = blackBrush;
    //     }
    // }
}