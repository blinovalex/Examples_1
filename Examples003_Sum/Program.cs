﻿using Internal;
using System.Data;
using System;
using System.Security.Cryptography;
using System.ComponentModel.DataAnnotations;
using System;
int numberA = new Random().Next(1, 10);
Console.WriteLine(numberA);
int numberB = new Random().Next(1, 10);
Console.WriteLine(numberB);
int result = numberA + numberB;
Console.WriteLine(result);