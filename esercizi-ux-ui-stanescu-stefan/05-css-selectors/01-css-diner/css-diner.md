# Solutions

01
plate

02 
bento

03 
#fancy

04 
plate apple

05 
#fancy pickle

06 
.small

07 
orange.small

08
 bento orange.small

09 
plate,bento 

10 
"*"

11 
plate * select

12 
plate + apple

13 
pickle ~ pickle

14
 plate > apple 

15 
orange:first-child

16 
plate pickle,apple:only-child 

17 
plate apple, pickle
            or              
apple, pickle:last-child 

18
plate:nth-child(3)

19 
bento:nth-last-child(3)

20 
apple:first-of-type

21 
plate:nth-of-type(even)

22 
plate:nth-of-type(2n+3)
plate (2)

23 
apple:only-child 

24 
orange:last-of-type,apple:last-of-type

25
 bento:empty selects empty elements

26 
apple:not(.small)

27 
apple:not(.small),plate,bento:last-of-type

28 
plate:nth-of-type(1),plate:nth-of-type(2)

29 
bento:nth-of-type(2)

30 
plate, bento:first-of-type

31 
bento, plate

32 
bento:nth-of-type(2n+1)


---------------------------------------------------------------------------
# Explanations

01
Type Selector: Selects all elements that have the given node name. In this case, it would select all elements with the tag name "plate".

02
Type Selector: Selects all elements that have the given node name. In this case, it would select all elements with the tag name "bento".

03
ID Selector: Selects an element based on the value of its id attribute. In this case, it would select the element with id "fancy".

04
Descendant Combinator: Selects elements that are descendants of a specified element. In this case, it would select all "apple" elements that are inside "plate" elements.

05
ID Selector and Type Selector: Selects the element with id "fancy" and all elements with the tag name "pickle".

06
Class Selector: Selects all elements with the given class attribute. In this case, it would select all elements with class "small".

07
Type Selector and Class Selector: Selects all elements with the tag name "orange" that also have the class "small".

08
Descendant Combinator: Selects elements that are descendants of a specified element. In this case, it would select all elements with the tag name "orange" that are inside elements with the tag name "bento".

09
Grouping Selector: Selects all the specified selectors. In this case, it would select all elements with the tag name "plate" and all elements with the tag name "bento".

10
Universal Selector: Selects all elements.

11
Descendant Combinator: Selects elements that are descendants of a specified element. In this case, it would select all elements that are inside "plate" elements.

12
Adjacent Sibling Combinator: Selects the first element that is the next sibling of the specified element. In this case, it would select the first "apple" element that is immediately after a "plate" element.

13
General Sibling Combinator: Selects siblings of an element that follow it. In this case, it would select all "pickle" elements that are siblings of another "pickle" element.

14
Child Combinator: Selects elements that are direct children of a specified element. In this case, it would select all "apple" elements that are direct children of "plate" elements.

15
:first-child Pseudo-class: Selects the first child element of its parent. In this case, it would select the first "orange" element that is the first child of its parent.

16
:only-child Pseudo-class: Selects an element that is the only child of its parent. In this case, it would select all elements that are the only child of their parent and have the tag name "pickle".

17
:last-child Pseudo-class: Selects the last child element of its parent. In this case, it would select the last "apple" element that is the last child of its parent.

18
:nth-child(n) Pseudo-class: Selects elements based on their position in a group of siblings. In this case, it would select the third "plate" element.

19
:nth-last-child(n) Pseudo-class: Selects elements based on their position in a group of siblings, counting from the end. In this case, it would select the third "bento" element from the end.

20
:first-of-type Pseudo-class: Selects the first element of its type within its parent. In this case, it would select the first "apple" element of its type within its parent.

21
:nth-of-type(even) Pseudo-class: Selects elements of a certain type, based on their position in a group of siblings. In this case, it would select all even "plate" elements.

22
:nth-of-type(An+B) Pseudo-class: Selects elements of a certain type, based on their position in a group of siblings. In this case, it would select every third "plate" element starting from the third one.

23
:only-child Pseudo-class: Selects an element that is the only child of its parent. In this case, it would select all "apple" elements that are the only child of their parent.

24
:last-of-type Pseudo-class: Selects the last element of its type within its parent. In this case, it would select the last "orange" and "apple" elements of their type within their parent.

25
:empty Pseudo-class: Selects elements that have no children. In this case, it would select all "bento" elements that have no children.

26
:not(.small) Pseudo-class: Selects elements that do not have the specified class. In this case, it would select all "apple" elements that do not have the class "small".

27
Type Selector: Selects all elements that have the given node name. In this case, it would select all elements with the tag name "apple" and "plate".

28
:nth-of-type(n) Pseudo-class: Selects elements of a certain type, based on their position in a group of siblings. In this case, it would select the first and second "plate" elements.

29
:nth-of-type(n) Pseudo-class: Selects elements of a certain type, based on their position in a group of siblings. In this case, it would select every second "bento" element starting from the first one.

30
Type Selector and :first-of-type Pseudo-class: Selects the first element of its type within its parent. In this case, it would select the first "plate" and "bento" elements of their type within their parent.

31
Type Selector: Selects all elements that have the given node name. In this case, it would select all elements with the tag name "bento" and "plate".

32
:nth-of-type(An+B) Pseudo-class: Selects elements of a certain type, based on their position in a group of siblings. In this case, it would select every second "bento" element starting from the first one.