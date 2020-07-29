using AutoMapper;
using FleetControl.BLL.Mappings;
using FleetControl.DAL.Models.Movements;
using FleetControl.DAL.SQLServer.Repository;
using System;
using System.Collections.Generic;
using System.Text;

namespace FleetControl.BLL.Services
{
    public class MovementsService
    {
        #region InitializeConstructor
        private IMovementsRepository _movementsRepository;
        private IMapper _mapper;
        public MovementsService(IMovementsRepository movementsRepository)
        {
            _movementsRepository = movementsRepository;
            AutoMapperConfiguration.InitializeAutoMapper();
            _mapper = AutoMapperConfiguration.config.CreateMapper();
        }
        #endregion

        public IEnumerable<ClientDebtViewModel> GetDebtByClientID(int clientID)
        {
            if (clientID <= 0)
                throw new ArgumentNullException("GetDebtByClientID");
            else
                return _movementsRepository.GetDebtByClientID(clientID);
        }

        public IEnumerable<long> GetPendingTransactionsID(int ClientID, long TransactionID)
        {
            if (ClientID <= 0)
                throw new ArgumentNullException("GetPendingTransactionsID");
            else
                return _movementsRepository.GetPendingTransactionsID(ClientID, TransactionID);
        }

        

        public bool DeletePSETransaction(long TransactionID)
        {
            if (TransactionID <= 0)
                throw new ArgumentNullException("DeletePSETransaction");
            else
                return _movementsRepository.DeletePSETransaction(TransactionID);
        }

        public bool ExistPendingLocalTransaction(int ClientID, long TransactionID)
        {
            if (ClientID <= 0)
                throw new ArgumentNullException("ExistPendingLocalTransaction");
            else
                return _movementsRepository.ExistPendingLocalTransaction(ClientID, TransactionID);
        }

        public bool ExistLocalTransaction(long TransactionID)
        {
            if (TransactionID <= 0)
                throw new ArgumentNullException("ExistLocalTransaction");
            else
                return _movementsRepository.ExistLocalTransaction(TransactionID);
        }
        

        public int CreateLocalPseTransaction(HeaderPseTransactionViewModel Header)
        {
            if (Header.ClientID <= 0)
                throw new ArgumentNullException("CreateLocalPseTransaction");
            else
                return _movementsRepository.CreateLocalPseTransaction(Header);
        }

        public int UpdateLocalPseTransaction(HeaderPseTransactionViewModel Header)
        {
            if (Header.TransactionID <= 0)
                throw new ArgumentNullException("UpdateLocalPseTransaction");
            else
                return _movementsRepository.UpdateLocalPseTransaction(Header);
        }

        

        public IEnumerable<GenerateReceiptPseResponse> GenerateReceiptPse(GenerateReceiptViewModel receiptData)
        {
            if (receiptData.NumberTransactionPSE <= 0)
                throw new ArgumentNullException("GenerateReceiptPse");
            else
                return _movementsRepository.GenerateReceiptPse(receiptData);
        }

        public void SendPseEmail(SendPseEmailViewModel emailData)
        {
            if (emailData.TransactionID <= 0)
                throw new ArgumentNullException("SendPseEmail");
            else
                 _movementsRepository.SendPseEmail(emailData);
        }
        


    }
}
