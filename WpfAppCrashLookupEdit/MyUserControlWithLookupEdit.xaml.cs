﻿using DevExpress.Xpo.Exceptions;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace WpfAppCrashLookupEdit;

/// <summary>
/// Interaction logic for MyUserControlWithLookupEdit.xaml
/// </summary>
public partial class MyUserControlWithLookupEdit : UserControl
{


    public MyUserControlWithLookupEdit()
    {
        InitializeComponent();
    }



 
    public string Account
    {
        get { return (string)GetValue(AccountProperty); }
        set { SetValue(AccountProperty, value); }
    }

    // Using a DependencyProperty as the backing store for Account.  This enables animation, styling, binding, etc...
    public static readonly DependencyProperty AccountProperty =
        DependencyProperty.Register("Account", typeof(string), typeof(MyUserControlWithLookupEdit), new PropertyMetadata(""));



    public ObservableCollection<Account> Accounts
    {
        get { return (ObservableCollection<Account>)GetValue(AccountsProperty); }
        set { SetValue(AccountsProperty, value); }
    }

    // Using a DependencyProperty as the backing store for Accounts.  This enables animation, styling, binding, etc...
    public static readonly DependencyProperty AccountsProperty =
        DependencyProperty.Register("Accounts", typeof(ObservableCollection<Account>), typeof(MyUserControlWithLookupEdit), new PropertyMetadata(null));



}
