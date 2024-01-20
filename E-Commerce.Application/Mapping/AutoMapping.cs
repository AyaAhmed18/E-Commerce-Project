﻿using AutoMapper;
using AutoMapper.Configuration;
using E_Commerce.DTOS.DTOS;
using E_Commerce_Project.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace E_Commerce.Application.Mapping
{
    public class AutoMapping:Profile
    {
        public AutoMapping(){
           // CreateMap<UserDTO, User>().ReverseMap();
        }

     public static UserDTO MapUserDto(User user)
            {
                if (user == null)
                {
                    return null;
                }
                return new UserDTO
                { Id = user.Id,
                 UserName=user.UserName,
                 Email=user.Email,//Phone=user.Phone,
                 Password=user.Password,Address=user.Address };
            }
     public static CategoryDTO MapCategoryDTO(Category category)
        {
           if (category == null)
           {
               return null;
           }
           return new CategoryDTO
           { Id = category.Id,
             CategoryName=category.CategoryName,
             Description=category.Description ,
             image = category.image
           };
        }
     public static ProductDTO MapProductDTO(Product product)
        {
            if (product == null)
            {
                return null;
            }
            return new ProductDTO
            {
                Id = product.Id,
                ProductName=product.ProductName,
                Price=product.Price,
                image=product.image,
                Quantity=product.Quantity,
                categoryID = product.categoryID
            };
        }
     public static OrderDTO MapOrderDTO(Order order)
        {
            if (order == null)
            {
                return null;
            }
            return new OrderDTO
            {
                Id = order.Id,
                NoOfProducts=order.NoOfProducts,
                OrderDate=order.OrderDate,
                Status=order.Status,
                TotalPrice=order.TotalPrice,
                UserID=order.UserID
            };
        }
     public static CartDTO MapCartDTO(Cart cart)
        {
            if (cart == null)
            {
                return null;
            }
            return new CartDTO
            {
                Id = cart.Id,
                Quantity = cart.Quantity,
                Status=cart.Status,
                UserId = cart.UserId
            };
        }
     public static CartDetailsDTO MapCartDetailsDTO(CartDetails cartDetails)
        {
            if (cartDetails == null)
            {
                return null;
            }
            return new CartDetailsDTO
            {
                Id = cartDetails.Id,
                cartID=cartDetails.cartID,
                productID=cartDetails.productID
                
            };
        }
     public static OrderItemDTO MapOrderItemDTO(OrderItems orderItems)
        {
            if (orderItems == null)
            {
                return null;
            }
            return new OrderItemDTO
            {
               id= orderItems.id,
               OrderId= orderItems.OrderId,
               productId= orderItems.productId

            };
        }
     public static User MapUser(UserDTO userDTO)
        {
            if (userDTO == null)
            {
                return null;
            }
            return new User
            {
                Id = userDTO.Id,
                UserName=userDTO.UserName,
                Email=userDTO.Email,
               // Phone = userDTO.Phone,
                Password=userDTO.Password,
                Address=userDTO.Address

            };

        }
     public static Category MapCategory(CategoryDTO categoryDTO)
        {
            if (categoryDTO == null)
            {
                return null;
            }
            return new Category
            {
                Id = categoryDTO.Id,
                CategoryName=categoryDTO.CategoryName,
                Description=categoryDTO.Description,
                image=categoryDTO.image
            };

        }
     public static Product MapProduct(ProductDTO productDto)
        {
            if (productDto == null)
            {
                return null;
            }
            return new Product
            {
                Id = productDto.Id,
                ProductName = productDto.ProductName,
                Price = productDto.Price,
                Quantity = productDto.Quantity,
                image = productDto.image,
                categoryID = productDto.categoryID
            };
        }
     public static Order MapOrder(OrderDTO orderDTO)
        {
            if (orderDTO == null)
            {
                return null;
            }
            return new Order
            {
                Id = orderDTO.Id,
                NoOfProducts = orderDTO.NoOfProducts,
                OrderDate = orderDTO.OrderDate,
                Status = orderDTO.Status,
                TotalPrice = orderDTO.TotalPrice,
                UserID = orderDTO.UserID,
            };
        }
     public static Cart MapCart(CartDTO cartDto)
        {
            if (cartDto == null)
            {
                return null;
            }
            return new Cart
            {
                Id = cartDto.Id,
                Quantity = cartDto.Quantity,
                Status = cartDto.Status,
                UserId = cartDto.UserId
            };
        }
     public static CartDetails MapCartDetails(CartDetailsDTO cartDetailsDto)
        {
            if (cartDetailsDto == null)
            {
                return null;
            }
            return new CartDetails
            {
                Id = cartDetailsDto.Id,
                cartID = cartDetailsDto.cartID,
                productID = cartDetailsDto.productID

            };
        }
     public static OrderItems MapOrderItem(OrderItemDTO orderItemsDTO)
        {
            if (orderItemsDTO == null)
            {
                return null;
            }
            return new OrderItems
            {
                id = orderItemsDTO.id,
                OrderId = orderItemsDTO.OrderId,
                productId = orderItemsDTO.productId

            };
        }
    }
}
