﻿using Cinema.Domain.DomainModels;
using Cinema.Domain.DTO;
using Cinema.Repository.Interface;
using Cinema.Services.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Cinema.Services.Implementation
{
    public class ShoppingCartService : IShoppingCartService
    {
        private readonly IRepository<ShoppingCart> _shoppingCartRepositorty;
        private readonly IRepository<Order> _orderRepositorty;
        private readonly IRepository<TicketInOrder> _ticketInOrderRepositorty;
        private readonly IUserRepository _userRepository;
        private readonly IRepository<EmailMessage> _mailRepository;

        public ShoppingCartService(IRepository<EmailMessage> mailRepository, IRepository<ShoppingCart> shoppingCartRepository, IRepository<TicketInOrder> ticketInOrderRepositorty, IRepository<Order> orderRepositorty, IUserRepository userRepository)
        {
            _shoppingCartRepositorty = shoppingCartRepository;
            _userRepository = userRepository;
            _orderRepositorty = orderRepositorty;
            _ticketInOrderRepositorty = ticketInOrderRepositorty;
            _mailRepository = mailRepository;
        }

        public bool deleteTicketFromShoppingCart(string userId, Guid id)
        {
            if (!string.IsNullOrEmpty(userId) && id != null)
            {

                var loggedInUser = this._userRepository.Get(userId);

                var userShoppingCart = loggedInUser.UserCart;

                var itemToDelete = userShoppingCart.TicketInShoppingCarts.Where(z => z.ShoppingCartId.Equals(id)).FirstOrDefault();

                userShoppingCart.TicketInShoppingCarts.Remove(itemToDelete);

                this._shoppingCartRepositorty.Update(userShoppingCart);

                return true;
            }

            return false;
        }

        public ShoppingCartDto getShoppingCartInfo(string userId)
        {
            var loggedInUser = this._userRepository.Get(userId);

            var userShoppingCart = loggedInUser.UserCart;

            var AllTickets = userShoppingCart.TicketInShoppingCarts.ToList();

            var allTicketPrice = AllTickets.Select(z => new
            {
                TicketPrice = z.Ticket.TicketPrice,
                Quanitity = z.Quantity
            }).ToList();

            var totalPrice = 0;


            foreach (var item in allTicketPrice)
            {
                totalPrice += item.Quanitity * item.TicketPrice;
            }


            ShoppingCartDto scDto = new ShoppingCartDto
            {
                TicketInShoppingCarts = AllTickets,
                TotalPrice = totalPrice
            };


            return scDto;

        }

        public bool orderNow(string userId)
        {
            if (!string.IsNullOrEmpty(userId))
            {

                var loggedInUser = this._userRepository.Get(userId);

                var userShoppingCart = loggedInUser.UserCart;

                EmailMessage mail = new EmailMessage();
                mail.MailTo = loggedInUser.Email;
                mail.Subject = "Successfully created order";
                mail.Status = false;

                Order order = new Order
                {
                    Id = Guid.NewGuid(),
                    User = loggedInUser,
                    UserId = userId
                };

                this._orderRepositorty.Insert(order);

                List<TicketInOrder> ticketInOrders = new List<TicketInOrder>();

                var result = userShoppingCart.TicketInShoppingCarts.Select(z => new TicketInOrder
                {
                    TicketId = z.Ticket.Id,
                    SelectedTicket=z.Ticket,
                    OrderId = order.Id,
                    UserOrder = order,
                    Quantity = z.Quantity
                }).ToList();


                StringBuilder sb = new StringBuilder();

                var totalPrice = 0;

                sb.AppendLine("Your order is completed. The order conains: ");

                for (int i = 1; i <= result.Count(); i++)
                {
                    var item = result[i - 1];

                    totalPrice += item.Quantity * item.SelectedTicket.TicketPrice;

                    sb.AppendLine(i.ToString() + ". " + item.SelectedTicket.Title + " with price of: " + item.SelectedTicket.TicketPrice + " and quantity of: " + item.Quantity);
                }

                sb.AppendLine("Total price: " + totalPrice.ToString());


                mail.Content = sb.ToString();


                ticketInOrders.AddRange(result);
                
                foreach (var item in ticketInOrders)
                {
                    this._ticketInOrderRepositorty.Insert(item);
                }

                loggedInUser.UserCart.TicketInShoppingCarts.Clear();

                this._userRepository.Update(loggedInUser);
                this._mailRepository.Insert(mail);

                return true;
            }
            return false;
        }
    }
}
