using AutoMapper;
using LAB2.Base;
using LAB2.ViewModels;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;

namespace LAB2
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        DataModel _model;
        DataViewModel _dataViewModel;
        IMapper _mapper;

        public App()
        {
            new Mapping().Create();

            var config = Config();

            _mapper = config.CreateMapper();

            _model = DataModel.Load();
            _dataViewModel = _mapper.Map<DataModel, DataViewModel>(_model);

            var window = new MainWindow() { DataContext = _dataViewModel};
            window.Show();
        }

        protected override void OnExit(ExitEventArgs e)
        {
            try
            {
                _model = _mapper.Map<DataViewModel, DataModel>(_dataViewModel);

                _model.Save();
            }
            catch (Exception)
            {
                base.OnExit(e);
                throw;
            }
        }

        private MapperConfiguration Config()
        {
            var config = new MapperConfiguration(cfg =>
            {
                cfg.CreateMap<DataModel, DataViewModel>()
                    .ForMember(dest => dest.Clients, opt => opt.MapFrom(src =>
                    new ObservableCollection<ClientViewModel>(src.Clients.Select(c =>
                    new ClientViewModel
                {
                    FirstName = c.FirstName,
                    LastName = c.LastName,
                    DayOfBirth = c.DayOfBirth,
                    PhoneNumber = c.PhoneNumber,
                    Email = c.Email,
                    Status = c.Status
                }))))
                    .ForMember(dest => dest.Policies, opt => opt.MapFrom(src =>
                    new ObservableCollection<PolicyViewModel>(src.Policies.Select(p =>
                    new PolicyViewModel
                {
                    Type = p.Type,
                    StartDate = p.StartDate,
                    EndDate = p.EndDate,
                    PremiumAmount = p.PremiumAmount,
                    CoverageAmount = p.CoverageAmount
                }))));

                cfg.CreateMap<DataViewModel, DataModel>()
                   .ForMember(dest => dest.Clients, opt => opt.MapFrom(src =>
                       src.Clients.Select(c =>
                           new Client
                           {
                               FirstName = c.FirstName,
                               LastName = c.LastName,
                               DayOfBirth = c.DayOfBirth,
                               PhoneNumber = c.PhoneNumber,
                               Email = c.Email,
                               Status = c.Status
                           })))
                   .ForMember(dest => dest.Policies, opt => opt.MapFrom(src =>
                       src.Policies.Select(p =>
                           new Policy
                           {
                               Type = p.Type,
                               StartDate = p.StartDate,
                               EndDate = p.EndDate,
                               PremiumAmount = p.PremiumAmount,
                               CoverageAmount = p.CoverageAmount
                           })));
            });

            return config;
        }
    }
}
