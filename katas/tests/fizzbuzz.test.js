const fizzbuzz = require('../src/fizzbuzz');

describe('FizzBuzz Kata', () => {
  
  test('devuelve "1" para 1', () => {
    expect(fizzbuzz(1)).toBe("1");
  });

  test('devuelve "2" para 2', () => {
    expect(fizzbuzz(2)).toBe("2");
  });

  test('devuelve "Fizz" para 3', () => {
    expect(fizzbuzz(3)).toBe("Fizz");
  });

  test('devuelve "Fizz" para múltiplos de 3', () => {
    expect(fizzbuzz(6)).toBe("Fizz");
    expect(fizzbuzz(9)).toBe("Fizz");
  });

  test('devuelve "Buzz" para 5', () => {
    expect(fizzbuzz(5)).toBe("Buzz");
  });

  test('devuelve "Buzz" para múltiplos de 5', () => {
    expect(fizzbuzz(10)).toBe("Buzz");
    expect(fizzbuzz(20)).toBe("Buzz");
  });

  test('devuelve "FizzBuzz" para múltiplos de 3 y 5', () => {
    expect(fizzbuzz(15)).toBe("FizzBuzz");
    expect(fizzbuzz(30)).toBe("FizzBuzz");
  });

  test('cobertura completa 1-100', () => {
    expect(fizzbuzz(1)).toBe("1");
    expect(fizzbuzz(15)).toBe("FizzBuzz");
    expect(fizzbuzz(98)).toBe("98");
    expect(fizzbuzz(99)).toBe("Fizz");
    expect(fizzbuzz(100)).toBe("Buzz");
  });
});
