﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Stylet;
using System.Threading;
using AddressBooks.Models;
using AddressBooks.Api;

namespace AddressBooks.ViewModels
{
    class MainShell : Conductor<IScreen>.Collection.OneActive
    {

        private readonly IAddressBooksApi _addressBooksApi;

        public MainShell(IAddressBooksApi addressBooksApi, AddressesPage addressesViewModel, GroupsPage groupsViewModel,
            AddressBooksPage addressBooksViewModel)
        {
            this._addressBooksApi = addressBooksApi;
            this.NotifyDataSetCanUpdate(null);
            this.Items.Add(addressesViewModel);
            this.Items.Add(groupsViewModel);
            this.Items.Add(addressBooksViewModel);

            this.ActiveItem = addressesViewModel;
        }


        Timer _dataSetUpdateTimer;

        public new void Deactivated()
        {
            _dataSetUpdateTimer = new Timer(NotifyDataSetCanUpdate, null, TimeSpan.Zero, TimeSpan.FromMinutes(0.5));
        }

        public new void Activated()
        {
            if (_dataSetUpdateTimer != null)
            {
                _dataSetUpdateTimer.Dispose();
            }
        }

        public void NotifyDataSetCanUpdate(object state)
        {
            ((CachedAddressBooksApi) _addressBooksApi).NotifyCanUpdate();
        }
    }
}
