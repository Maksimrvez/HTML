# БАЗОВЫЙ СИНТАКСИС

**Теги и их атрибуты пишутся строчными буквами.**
**Для значений атрибутов всегда используются двойные кавычки.**
**Для отступов у вложенных элементов используется табуляция (рекомендуется выставлять размер табуляции - 2).**

~~~
<!DOCTYPE html>
<html lang="en">
<head>
  <meta charset="UTF-8">
  <title>Страница на HTML</title>
</head>
<body>
  <h1>Моя первая страница</h1>
  <p>Описание моей первой страницы</p>
</body>
</html>
~~~
## ЗАКРЫВАЮЩИЕ ТЕГИ

**Закрывающий слеш у одиночных тегов (img, br и другие) не ставится.**
**В остальных случаях (таких, как body или ul) обязателен закрывающий тег.**

~~~
<body>
  <ul>
    <li>Один</li>
    <li>Два</li>
    <li>Три</li>
  </ul>
</body>
~~~

## HTML-DOCTYPE

**В начале страницы обязательно должен быть указан актуальный DOCTYPE , чтобы браузер отображал её в режиме соответствия стандартам. Сейчас версия html5.**

~~~				
<!DOCTYPE html>
<html lang="ru">
  <head>…</head>
  <body>…</body>
</html>
~~~
					
## КОДИРОВКА СИМВОЛОВ

**Кодировка символов на странице всегда должна быть явно указана, чтобы обеспечить корректное отображение текста. В нашем случае нужно utf-8 кодировка.**
							
~~~
<head>
  <meta charset="utf-8">
  <title>Заголовок страницы</title>
</head>
~~~
						
## АТРИБУТ ЯЗЫКА

**Для элемента html в атрибуте lang должен указываться соответствующий язык документа.**
**Это нужно для правильной работы синтеза речи, для переводчиков и т.д.**

~~~							
<!DOCTYPE html>
<html lang="ru">
...
</html
~~~
						
## РЕЖИМ СОВМЕСТИМОСТИ IE

**Internet Explorer поддерживает специальный мета-тег, который указывает, в какой версии следует показать страницу. На данный момент целесообразно использовать так называемый Edge-мод.**

**Подробнее тут.**

~~~							
<meta http-equiv="X-UA-Compatible" content="IE=Edge">
~~~
						
## ПОДКЛЮЧЕНИЕ СТИЛЕЙ

**тилевые файлы с помощью link подключаются внутри head. Атрибут type не указывается. А вот атрибут rel - обязателен, иначе страница "не поймет", что вы подключили.**

~~~
<!-- Правильно: стилевой файл подключён в секции head -->
<!DOCTYPE html>
<html lang="ru">
  <head>
    <link rel="stylesheet" href="main.css">
  </head>
  <body>…</body>
</html>
~~~
						
~~~							
<!-- Неправильно: стилевой файл подключён в секции body -->
<!DOCTYPE html>
<html lang="ru">
  <head>…</head>
  <body>
    <link rel="stylesheet" href="main.css">
  </body>
</html>
~~~
						
## ПОРЯДОК АТРИБУТОВ

**Атрибут класса у HTML-элементов пишется первым. Это важно для идентичности написания кода. Так проще увидеть какой-либо class, id и т.д. Остальные атрибуты можно указывать в любом порядке, но желательно чтобы их порядок от элемента к элементу сохранялся.**

~~~							
<a class="element element-big" id="element" href="/" data-name="element">Ссылка</a>

<input class="form-control" type="text" name="test">

<img class="pets-picture" src="cats.jpg" alt="Изображение котиков">
~~~
						
## ЛОГИЧЕСКИЕ АТРИБУТЫ

**Для логических атрибутов (например, checked, disabled, required) значение не указывается, а сами атрибуты указываются последними и в единообразной последовательности во всём документе.**

~~~							
<!-- disabled="disabled" необязательно -->
<input type="checkbox" required checked>

<input type="text" disabled>

<select>
<option value="1" selected>1</option>
</select>
~~~
						
## СВЯЗИ ПОЛЕЙ ВВОДА

**Для улучшения взаимодействия пользователя с элементами форм, при нажатии на подпись поля, оно должно активироваться. Для этого элемент формы связывается с его описанием с помощью идентификатора и атрибута for тега label.**

~~~							
<!-- Правильно: элемент формы radio связан с подписью через идентификатор -->
<input type="radio" id="choose">
<label for="choose">Радио кнопка</label>

<!-- Правильно: элемент формы radio и подпись обёрнуты в label -->
<label>
  <input type="radio"> Радио кнопка
</label>

<!-- Неправильно: подпись не связана с элементом формы -->
<input type="radio" id="choose"> Радио кнопка
~~~
						
## АТРИБУТ ALT

**Обязательно нужно указывать атрибут alt у тега img, чтобы было чем "заменить" непоявившееся по любой причине изображение.**
							
~~~
<!-- Правильно: атрибут alt задан -->
<img src="img/picture.png" alt="Картинка">

<!-- Неправильно: атрибут не задан -->
<img src="img/picture.png" alt="">
~~~
						
## ВАЛИДНОСТЬ

**Документ должен проходить проверку на валидность. Для проверки используется современный валидатор.**

## Определения и значения html тегов

- [X] HTML-элемент p представляет собой абзац.
~~~
<p></p>
~~~
> **Абзацы обычно представлены в визуальной среде в виде блоков текста, отделённых от соседних блоков пустыми строками и/или отступом в первой строке, кроме этого HTML-абзацы могут представлять собой структурную группировку однотипного содержимого, например изображений или полей формы.**

- [X] Тег head
~~~
<head></head>
~~~
>**Предназначен для хранения служебной информации о странице.**
**Он располагается первым в теге <html>, сразу перед <body>.**
**Внутри <head> обычно содержится заголовок, ключевые слова, описание страницы и другие служебные данные.**

- [X] Тег html
~~~
<html></html>
~~~
> **Указывает программе просмотра страниц, что это HMTL документ.**

- [X] Тег li
~~~
<li></li>
~~~
> **HTML тег <li> (li сокращение от англ. list item - элемент списка) определяет пункты списка и может включать в себя любые другие HTML-элементы (списки, абзацы, изображения и др.). По умолчанию браузеры отображают пункты списка с небольшим отступом с левой стороны.**

- [X] Тег (a href="")
~~~
<a></a>
~~~
> **(от англ. a nchor - якорь, ссылка) предназначен для создания ссылок. Для этого необходимо сообщить браузеру, что является ссылкой, а также указать адрес документа, на который следует сделать ссылку. В качестве значения атрибута href используется адрес документа, на который происходит переход. Адрес ссылки может быть абсолютным и относительным.**

- [X] Тег body
~~~
<body></body>
~~~
> **Тег (от англ. body - тело) предназначен для хранения содержимого веб-страницы (контента), отображаемого в окне браузера. Информацию, которую следует выводить в документе, следует располагать именно внутри контейнера< body>. К такой информации относится текст, изображения, теги, скрипты JavaScript и т. д.< body> также применяется для определения цветов ссылок и текста на веб-странице.**

- [X] h1(h2,h3,h4)
~~~
<h1></h1>
~~~
> **Н1 и H2 (а, точнее, h1 и h2) – html теги, которые показывают важность текста, следующего после них.** 
> **Их еще называют тегами акцентирования. Вообще-то, существует 6 уровней заголовков: от H1 до H6. Соответственно, наибольший вес имеет заголовок H1, заголовок H2 является второстепенным, а заголовок шестого уровня H6 наименее значим.**
