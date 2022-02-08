#!/usr/bin/env python
# coding: utf-8

# In[4]:


import pytest
import selenium.webdriver 


# In[6]:


@pytest.fixture
def browser(): 
    
    # Initialize the ChromeDriver instance 
    b = selenium.webdriver.Chrome()
    
    # Make the calls wait up to 10 seconds for elements to appear 
    b.implicitly_wait(10)
    
    # Return the WebDriver instance for the setup 
    yield b 
    
    # Quit the WebDriver instance for the cleanup 
    b.quit()


# In[ ]:




