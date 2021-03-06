<body style="
  background-color:#151d28; 
  color: #c7cfcc;  
  margin-top: 50px;
  margin-bottom: 50px;
  margin-right: 50px;
  margin-left: 50px;">

<style>
table th:first-of-type  { width: 3%;  }
table th:nth-of-type(2) { width: 45%; }
table th:nth-of-type(3) { width: 15%; }
table th:nth-of-type(4) { width: 37%; }
</style>

# Bouncee maths

## Linear

| Name  | Function                              | Domain                                            | Graph                            |
| ----- | ------------------------------------- | ------------------------------------------------- | -------------------------------- |
| In    | $f(x) = x$                            | $\{ 0 \le x \le 1\}$                              | <img src="./easeLong/0ease.png"> |
| Spike | $f(x) = 2 x$ <br />  $g(x) = 2 (1-x)$ | $\{ 0 \le x \le 0.5\}$ <br /> $\{0.5 < x \le 1\}$ | <img src="./easeLong/3ease.png"> |

## Sinus

| Name  | Function                                                | Domain                                            | Graph                            |
| ----- | ------------------------------------------------------- | ------------------------------------------------- | -------------------------------- |
| In    | $f(x) = -cos (0.5x \pi) + 1$                            | $\{ 0 \le x \le 1\}$                              | <img src="./easeLong/4ease.png"> |
| Out   | $f(x) =  sin (0.5x \pi )$                               | $\{ 0 \le x \le 1\}$                              | <img src="./easeLong/5ease.png"> |
| InOut | $f(x) = -0.5 cos(x \pi) + 0.5$                          | $\{ 0 \le x \le 1\}$                              | <img src="./easeLong/6ease.png"> |
| Spike | $f(x) = -cos(x \pi) + 1$ <br /> $g(x) = cos(x \pi) + 1$ | $\{ 0 \le x \le 0.5\}$ <br /> $\{0.5 < x \le 1\}$ | <img src="./easeLong/7ease.png"> |

## Blinn-Wyvill Approximation to the Raised Inverted Cosine
Optimization for the sinus functions

| Name  | Function                                                                                                     | Domain                                            |
| ----- | ------------------------------------------------------------------------------------------------------------ | ------------------------------------------------- |
| In    | $f(x) = 8(0.5x)^6 / 9 - 34(0.5x)^4 / 9 + 44(0.5x)^2 / 9$                                                     | $\{ 0 \le x \le 1\}$                              |
| Out   | $f(x) = 8(0.5(1 - x))^6 / 9 - 34(0.5(1 - x))^4 / 9 + 44(0.5(1 - x))^2 / 9 - 1$                               | $\{ 0 \le x \le 1\}$                              |
| InOut | $f(x) = 4x^6 / 9 - 17x^4 / 9 + 22x^2 / 9$                                                                    | $\{ 0 \le x \le 1\}$                              |
| Spike | $f(x) = 8x^6 / 9 - 34x^4 / 9 + 44x^2 / 9$ <br /> $g(x) = 8(1 - x)^6 / 9 - 34(1 - x)^4 / 9 + 44(1 - x)^2 / 9$ | $\{ 0 \le x \le 0.5\}$ <br /> $\{0.5 < x \le 1\}$ |

<div style="page-break-after: always;"></div> <br /> <br />

## Quadratic

| Name  | Function                                            | Domain                                            | Graph                             |
| ----- | --------------------------------------------------- | ------------------------------------------------- | --------------------------------- |
| In    | $f(x) = x^2$                                        | $\{ 0 \le x \le 1\}$                              | <img src="./easeLong/8ease.png">  |
| Out   | $f(x) =  1 - (x - 1)^2$                             | $\{ 0 \le x \le 1\}$                              | <img src="./easeLong/9ease.png">  |
| InOut | $f(x) = 2 x^2$ <br /> $g(x) = 1 - 0.5 (2  x - 2)^2$ | $\{ 0 \le x \le 0.5\}$ <br /> $\{0.5 < x \le 1\}$ | <img src="./easeLong/10ease.png"> |
| Spike | $f(x) = 4 x^2$ <br /> $g(x) = (2  x - 2)^2$         | $\{ 0 \le x \le 0.5\}$ <br /> $\{0.5 < x \le 1\}$ | <img src="./easeLong/11ease.png"> |

## Cubic

| Name  | Function                                       | Domain                                            | Graph                             |
| ----- | ---------------------------------------------- | ------------------------------------------------- | --------------------------------- |
| In    | $f(x) = x^3$                                   | $\{ 0 \le x \le 1\}$                              | <img src="./easeLong/12ease.png"> |
| Out   | $f(x) = 1 + (x - 1)^3$                         | $\{ 0 \le x \le 1\}$                              | <img src="./easeLong/13ease.png"> |
| InOut | $f(x) = 4 x^3$ <br /> $g(x) = 1 + 4 (x - 1)^3$ | $\{ 0 \le x \le 0.5\}$ <br /> $\{0.5 < x \le 1\}$ | <img src="./easeLong/14ease.png"> |
| Spike | $f(x) = 8 x^3$ <br /> $g(x) = -(2  x - 2)^3$   | $\{ 0 \le x \le 0.5\}$ <br /> $\{0.5 < x \le 1\}$ | <img src="./easeLong/15ease.png"> |

<div style="page-break-after: always;"></div> <br /> <br />

## Quartic

| Name  | Function                                                         | Domain                                            | Graph                             |
| ----- | ---------------------------------------------------------------- | ------------------------------------------------- | --------------------------------- |
| In    | $f(x) = x^4$                                                     | $\{ 0 \le x \le 1\}$                              | <img src="./easeLong/16ease.png"> |
| Out   | $f(x) =  1 - (x - 1)^4$                                          | $\{ 0 \le x \le 1\}$                              | <img src="./easeLong/17ease.png"> |
| InOut | $f(x) = 0.5 - 8 (x - 0.5)^4$ <br /> $g(x) = 0.5 + 8 (x - 0.5)^4$ | $\{ 0 \le x \le 0.5\}$ <br /> $\{0.5 < x \le 1\}$ | <img src="./easeLong/18ease.png"> |
| Spike | $f(x) = 16 x^4$ <br /> $g(x) = (2  x - 2)^4$                     | $\{ 0 \le x \le 0.5\}$ <br /> $\{0.5 < x \le 1\}$ | <img src="./easeLong/19ease.png"> |

## Quintic

| Name  | Function                                         | Domain                                            | Graph                             |
| ----- | ------------------------------------------------ | ------------------------------------------------- | --------------------------------- |
| In    | $f(x) = x^5$                                     | $\{ 0 \le x \le 1\}$                              | <img src="./easeLong/20ease.png"> |
| Out   | $f(x) = 1 + (x - 1)^5$                           | $\{ 0 \le x \le 1\}$                              | <img src="./easeLong/21ease.png"> |
| InOut | $f(x) = 16 x^5$ <br /> $g(x) = 1 + 16 (x - 1)^5$ | $\{ 0 \le x \le 0.5\}$ <br /> $\{0.5 < x \le 1\}$ | <img src="./easeLong/22ease.png"> |
| Spike | $f(x) = 32 x^5$ <br /> $g(x) = -(2  x - 2)^5$    | $\{ 0 \le x \le 0.5\}$ <br /> $\{0.5 < x \le 1\}$ | <img src="./easeLong/23ease.png"> |

<div style="page-break-after: always;"></div> <br /> <br />

## Exponential

| Name  | Function                                                                  | Domain                                            | Graph                             |
| ----- | ------------------------------------------------------------------------- | ------------------------------------------------- | --------------------------------- |
| In    | $f(x) = 1 - \sqrt{ 1 - x}$                                                | $\{ 0 \le x \le 1\}$                              | <img src="./easeLong/24ease.png"> |
| Out   | $f(x) = \sqrt{x}$                                                         | $\{ 0 \le x \le 1\}$                              | <img src="./easeLong/25ease.png"> |
| InOut | $f(x) = 0.5 - 0.5 \sqrt{1 - 2 x}$ <br /> $g(x) = 0.5 + 0.5 \sqrt{2x - 1}$ | $\{ 0 \le x \le 0.5\}$ <br /> $\{0.5 < x \le 1\}$ | <img src="./easeLong/26ease.png"> |
| Spike | $f(x) = 1 - \sqrt{1 - 2 x}$ <br /> $g(x) = 1 + \sqrt{2x - 1}$             | $\{ 0 \le x \le 0.5\}$ <br /> $\{0.5 < x \le 1\}$ | <img src="./easeLong/27ease.png"> |

## Circular

| Name  | Function                                                                       | Domain                                            | Graph                             |
| ----- | ------------------------------------------------------------------------------ | ------------------------------------------------- | --------------------------------- |
| In    | $f(x) = 1 - \sqrt{ 1 - x^2}$                                                   | $\{ 0 \le x \le 1\}$                              | <img src="./easeLong/28ease.png"> |
| Out   | $f(x) = \sqrt{ 1 - (x - 1)^2}$                                                 | $\{ 0 \le x \le 1\}$                              | <img src="./easeLong/29ease.png"> |
| InOut | $f(x) = 0.5 - \sqrt{0.25 - x^2}$ <br /> $g(x) = 0.5 + \sqrt{0.25 - (x - 1)^2}$ | $\{ 0 \le x \le 0.5\}$ <br /> $\{0.5 < x \le 1\}$ | <img src="./easeLong/30ease.png"> |
| Spike | $f(x) = 1 - \sqrt{1 - 4x^2}$ <br /> $g(x) = 1 - \sqrt{2x - 2}^2$               | $\{ 0 \le x \le 0.5\}$ <br /> $\{0.5 < x \le 1\}$ | <img src="./easeLong/31ease.png"> |

<div style="page-break-after: always;"></div> <br /> <br />

## Bounce

s = 7.5625 (scalar that narrows parabola)

d = 2.75 (offset on the x axis)

| Name  | Function                                                                                                                                                                                                                                                                                                                                                                                                                                                                   | Domain                                                                                                                                                                                                                                                                                   |
| ----- | -------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------- | ---------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------- |
| In    | $f(x) = 1 - sx^2$<br />$g(x) = 1 - s(x - {1.5}/{d})^2 - 0.75$<br />$h(x) = 1 - s(x - {2.25}/{d})^2 - 0.9375$ <br /> $i(x) = 1 - s(x - {2.625}/{d})^2 - 0.984375$                                                                                                                                                                                                                                                                                                           | $\{ 0 \le x < {1}/{d}\}$ <br />  $\{ {1}/{d} \le x < {2}/{d}\}$ <br />  $\{ {2}/{d} \le x < {5}/{4d}\}$ <br /> $\{ {5}/{4d} \le x < 1\}$ <br />                                                                                                                                          |
| Out   | $f(x) = sx^2$ <br /> $g(x) = s(x -{1.5}/{d})^2 - 0.75$ <br /> $h(x) = s(x - {2.25}/{d})^2 - 0.9375$ <br /> $i(x) = s(x - {2.625}/{d})^2 - 0.984375$                                                                                                                                                                                                                                                                                                                        | $\{ 0 \le x < {1}/{d}\}$ <br />  $\{ {1}/{d} \le x < {2}/{d}\}$ <br />  $\{ {2}/{d} \le x < {5}/{4d}\}$ <br />  $\{ {5}/{4d} \le x < 1\}$                                                                                                                                                |
| InOut | $f(x) = (1 - (s( 1 - 2x - {2.625}/{d})^2 + 0.984375)) / 2$ <br /> $g(x) = (1 - (s( 1 - 2x - {2.5}/{d})^2 + 0.9375)) / 2$ <br /> $h(x) = (1 - (s( 1 - 2x - {1.5}/{d})^2 + 0.75)) / 2$ <br /> $i(x) = (1 - (s( 1 - 2x)^2)) / 2$ <br /> $j(x) = (0.5 + (s( 1 - 2x)^2)) / 2$ <br /> $k(x) = (0.5 + (s( 1 - 2x - {1.5}/{d})^2 + 0.75)) / 2$ <br /> $l(x) = (0.5 + (s(1 - 2x - {2.5}/{d})^2 + 0.9375)) / 2$ <br /> $m(x) = (0.5 + (s( 1 - 2x - {2.625}/{d})^2 + 0.984375)) / 25$ | $\{ 0 \le x < {1}/{2d}\}$ <br /> $\{ {1}/{2d} \le x < {1}/{d}\}$ <br /> $\{ {1}/{d} \le x < d\}$ <br />  $\{ d \le x < {2}/{d}\}$ <br />  $\{ {2}/{d} \le x < {5}/{4d}\}$ <br />  $\{ {5}/{4d} \le x < {5}/{2d}\}$ <br /> $\{ {5}/{2d} \le x < 0.5\}$ <br /> $\{ 0.5 \le x < 1\}$ <br /> |
| Spike | $f(x) = 1 - (s( 1 - 2x - {2.625}/{d})^2 + 0.984375)$ <br /> $g(x) = 1 - (s( 1 - 2x - {2.5}/{d})^2 + 0.9375)$ <br /> $h(x) = 1 - (s( 1 - 2x - {1.5}/{d})^2 + 0.75)$ <br /> $i(x) = 1 - (s( 1 - 2x)^2)$ <br /> $j(x) = 1 - (s( 1 - 2(1 - x) - {1.5}{d})^2 + 0.75))$ <br /> $k(x) = 1 - (s(1 - 2(1 - x) - {2.5}/{d})^2 + 0.9375))$ <br /> $l(x) = 1 - (s( 1 - 2(1 - x) - {2.625}/{d})^2 + 0.984375)$                                                                          | $\{ 0 \le x < {1}/{2d}\}$ <br /> $\{ {1}/{2d} \le x < {1}/{d}\}$ <br /> $\{ {1}/{d} \le x < d\}$ <br />  $\{ d \le x < {5}/{4d}\}$  <br />  $\{ {5}/{4d} \le x < {5}/{2d}\}$ <br />  $\{ {5}/{2d} \le x < 0.5\}$ <br /> $\{ 0.5 \le x < 1\}$ <br />                                      |

---

<div style="text-align:center">In and Out</div>

<div style="text-align:center"><img src="./easeLong/32ease.png" style="width:35%;">  <img src="./easeLong/33ease.png" style="width:35%;"></div>

<div style="text-align:center">InOut and Spike</div>

<div style="text-align:center"><img src="./easeLong/34ease.png" style="width:35%;">  <img src="./easeLong/35ease.png" style="width:35%;"></div>

<div style="page-break-after: always;"></div> <br /> <br />

## Elastic

a = 1f * 2f (just because)

p = 3f * 1.65f (just because)

| Name  | Function                                                                                                              | Domain                                      |
| ----- | --------------------------------------------------------------------------------------------------------------------- | ------------------------------------------- |
| In    | $f(x) = - (ax)^2 sin(2 \pi p(x - 0.75))$                                                                              | $\{ 0 < x < 1\}$                            |
| Out   | $f(x) =  1 + (a(1-x))^2 sin(2 \pi p((1 - x) - 0.75))$                                                                 | $\{ 0 < x < 1\}$                            |
| InOut | $f(x) = 0.5 + 0.5 (-(ax)^2) sin(2 \pi p(x - 0.75))$ <br /> $g(x) = 0.5 + 0.5 (a(1-x))^2 sin(2 \pi p((1 - x) - 0.75))$ | $\{ 0 < x < 0.5\}$ <br /> $\{0.5 < x < 1\}$ |
| Spike | $f(x) = 0.5 - 0.5 (ax)^2 sin(2 \pi p(x - 0.75))2$ <br /> $g(x) = 0.5 + 0.5 (a(1-x))^2 sin(2 \pi p((1 - x) - 0.75))$   | $\{ 0 < x < 0.5\}$ <br /> $\{0.5 < x < 1\}$ |

---
<br />

<div style="text-align:center">In and Out</div>

<div style="text-align:center"><img src="./easeLong/36ease.png" style="width:35%;">  <img src="./easeLong/37ease.png" style="width:35%;"></div>

<div style="text-align:center">InOut and Spike</div>

<div style="text-align:center"><img src="./easeLong/38ease.png" style="width:35%;">  <img src="./easeLong/39ease.png" style="width:35%;"></div>

<div style="page-break-after: always;"></div> <br /> <br />

## Back

a = 1.70158f

p = 1.75f (multiplier for the ease in out)

p = 2f (for the spike)

| Name  | Function                                                                                | Domain                                      | Graph                             |
| ----- | --------------------------------------------------------------------------------------- | ------------------------------------------- | --------------------------------- |
| In    | $f(x) = (a + 1)x^3 - ax^2$                                                              | $\{ 0 \le x \le 1\}$                        | <img src="./easeLong/40ease.png"> |
| Out   | $f(x) = 1 - (a + 1)(1 - x)^3 + a(1 - x)^2$                                              | $\{ 0 \le x \le 1\}$                        | <img src="./easeLong/41ease.png"> |
| InOut | $f(x) = (a + 1)(px)^3 - a(px)^2$ <br /> $g(x) = 1 - (a + 1) (p(1 - x))^3 - a(p(1-x))^2$ | $\{ 0 < x < 0.5\}$ <br /> $\{0.5 < x < 1\}$ | <img src="./easeLong/42ease.png"> |
| Spike | $f(x) = (a + 1) (px)^3 - a(px)^2$ <br /> $g(x) = (a + 1) (p(1 - x))^3 - a(p(1 - x))^2$  | $\{ 0 < x < 0.5\}$ <br /> $\{0.5 < x < 1\}$ | <img src="./easeLong/43ease.png"> |

<div style="page-break-after: always;"></div>  <br />

---

</body>
