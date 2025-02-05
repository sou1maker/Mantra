﻿using System.Diagnostics;
using System.Windows;

namespace Mantra;

/// <summary>
/// Interaction logic for App.xaml
/// </summary>
public partial class App
{
    protected override void OnStartup(StartupEventArgs e)
    {
        base.OnStartup(e);

        Debug.WriteLine(
@"//            _____                    _____                    _____                _____                    _____                    _____          
//           /\    \                  /\    \                  /\    \              /\    \                  /\    \                  /\    \         
//          /::\____\                /::\    \                /::\____\            /::\    \                /::\    \                /::\    \        
//         /::::|   |               /::::\    \              /::::|   |            \:::\    \              /::::\    \              /::::\    \       
//        /:::::|   |              /::::::\    \            /:::::|   |             \:::\    \            /::::::\    \            /::::::\    \      
//       /::::::|   |             /:::/\:::\    \          /::::::|   |              \:::\    \          /:::/\:::\    \          /:::/\:::\    \     
//      /:::/|::|   |            /:::/__\:::\    \        /:::/|::|   |               \:::\    \        /:::/__\:::\    \        /:::/__\:::\    \    
//     /:::/ |::|   |           /::::\   \:::\    \      /:::/ |::|   |               /::::\    \      /::::\   \:::\    \      /::::\   \:::\    \   
//    /:::/  |::|___|______    /::::::\   \:::\    \    /:::/  |::|   | _____        /::::::\    \    /::::::\   \:::\    \    /::::::\   \:::\    \  
//   /:::/   |::::::::\    \  /:::/\:::\   \:::\    \  /:::/   |::|   |/\    \      /:::/\:::\    \  /:::/\:::\   \:::\____\  /:::/\:::\   \:::\    \ 
//  /:::/    |:::::::::\____\/:::/  \:::\   \:::\____\/:: /    |::|   /::\____\    /:::/  \:::\____\/:::/  \:::\   \:::|    |/:::/  \:::\   \:::\____\
//  \::/    / ~~~~~/:::/    /\::/    \:::\  /:::/    /\::/    /|::|  /:::/    /   /:::/    \::/    /\::/   |::::\  /:::|____|\::/    \:::\  /:::/    /
//   \/____/      /:::/    /  \/____/ \:::\/:::/    /  \/____/ |::| /:::/    /   /:::/    / \/____/  \/____|:::::\/:::/    /  \/____/ \:::\/:::/    / 
//               /:::/    /            \::::::/    /           |::|/:::/    /   /:::/    /                 |:::::::::/    /            \::::::/    /  
//              /:::/    /              \::::/    /            |::::::/    /   /:::/    /                  |::|\::::/    /              \::::/    /   
//             /:::/    /               /:::/    /             |:::::/    /    \::/    /                   |::| \::/____/               /:::/    /    
//            /:::/    /               /:::/    /              |::::/    /      \/____/                    |::|  ~|                    /:::/    /     
//           /:::/    /               /:::/    /               /:::/    /                                  |::|   |                   /:::/    /      
//          /:::/    /               /:::/    /               /:::/    /                                   \::|   |                  /:::/    /       
//          \::/    /                \::/    /                \::/    /                                     \:|   |                  \::/    /        
//           \/____/                  \/____/                  \/____/                                       \|___|                   \/____/         
//                                                                                                                                                    ");
    }
}